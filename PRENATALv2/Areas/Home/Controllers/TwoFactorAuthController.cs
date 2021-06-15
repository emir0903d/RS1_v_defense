using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PRENATALv2.Areas.Home.Models;

namespace PRENATALv2.Areas.Home.Controllers
{
   [Area("Home")]
   [Authorize(Roles =("Patient, Doctor, Nurse, Admin"))]
   [AutoValidateAntiforgeryToken]
    public class TwoFactorAuthController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private readonly UrlEncoder _urlEncoder;

        private const string AuthenticatorUriFormat = "otpauth://totp/{0}:{1}?secret={2}&issuer={0}&digits=6";
        private const string RecoveryCodesKey = nameof(RecoveryCodesKey);

        public TwoFactorAuthController(UserManager<AppUser> userManager, UrlEncoder urlEncoder)
        {
            UserMgr = userManager;
            _urlEncoder = urlEncoder;
        }


        public async Task<IActionResult> GenerateRecoveryCodes()
        {
            AppUser user = await UserMgr.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{UserMgr.GetUserId(User)}'.");
            }

            if (!user.TwoFactorEnabled)
            {
                throw new ApplicationException($"Cannot generate recovery codes for user with ID '{user.Id}' as they do not have 2FA enabled.");
            }

            var recoveryCodes = await UserMgr.GenerateNewTwoFactorRecoveryCodesAsync(user, 10);
            
            _recoveryCodes model = new _recoveryCodes {
                RecoveryCodes = recoveryCodes.ToArray()
            };

            return PartialView("_ShowRecoveryCodes", model);
        }

        public async Task<IActionResult> Disable2FA()
        {
            AppUser user = await UserMgr.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{UserMgr.GetUserId(User)}'.");
            }

            var disable2faResult = await UserMgr.SetTwoFactorEnabledAsync(user, false);
            if (!disable2faResult.Succeeded)
            {
                throw new ApplicationException($"Unexpected error occured disabling 2FA for user with ID '{user.Id}'.");
            }

            return Redirect("/Home/Profile/ShowProfile?Id=" + user.Id);
        }

        public async Task<IActionResult> TwoFactorAuthDetails()
        {
            AppUser user = await UserMgr.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{UserMgr.GetUserId(User)}'.");
            }

            _2FAdetails model = new _2FAdetails
            {
                RecoveryCodesLeft = await UserMgr.CountRecoveryCodesAsync(user)
            };

            return PartialView("_TwoFactorAuthDetails",model);
        }

        [HttpPost]
        public async Task<IActionResult> AttemptEnableAuthenticator(_2FAenable model)
        {
            AppUser user = await UserMgr.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{UserMgr.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadSharedKeyAndQrCodeUriAsync(user, model);
                return PartialView("_EnableAuthenticator",model);
            }


            var verificationCode = model.Code.Replace(" ", string.Empty).Replace("-", string.Empty);

            var is2faTokenValid = await UserMgr.VerifyTwoFactorTokenAsync(
                user, UserMgr.Options.Tokens.AuthenticatorTokenProvider, verificationCode);

            if (!is2faTokenValid)
            {
                ModelState.AddModelError("Code", "Verification code is invalid.");
                await LoadSharedKeyAndQrCodeUriAsync(user, model);
                return View("_EnableAuthenticator", model);
            }

            await UserMgr.SetTwoFactorEnabledAsync(user, true);

            var recoveryCodes = await UserMgr.GenerateNewTwoFactorRecoveryCodesAsync(user, 10);
            _recoveryCodes _rc = new _recoveryCodes {
                RecoveryCodes = recoveryCodes.ToArray() 
            };
            
            return PartialView("_ShowRecoveryCodes", _rc);
            
        }
        
        [HttpGet]
        public async Task<IActionResult> EnableAuthenticator()
        {
            AppUser user = await UserMgr.GetUserAsync(User);
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{UserMgr.GetUserId(User)}'.");
            }
            if (user.TwoFactorEnabled == true)
            {
                return RedirectToAction("TwoFactorAuthDetails");
            }
            await UserMgr.ResetAuthenticatorKeyAsync(user);
            _2FAenable model = new _2FAenable();
            await LoadSharedKeyAndQrCodeUriAsync(user, model);
            return PartialView("_EnableAuthenticator",model);
        }
        private async Task LoadSharedKeyAndQrCodeUriAsync(AppUser user, _2FAenable model)
        {
            var unformattedKey = await UserMgr.GetAuthenticatorKeyAsync(user);
            if (string.IsNullOrEmpty(unformattedKey))
            {
                await UserMgr.ResetAuthenticatorKeyAsync(user);
                unformattedKey = await UserMgr.GetAuthenticatorKeyAsync(user);
            }

            model.SharedKey = FormatKey(unformattedKey);
            model.AuthenticatorUri = GenerateQrCodeUri(user.UserName, unformattedKey);
        }
        private string FormatKey(string unformattedKey)
        {
            var result = new StringBuilder();
            int currentPosition = 0;
            while (currentPosition + 4 < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition, 4)).Append(" ");
                currentPosition += 4;
            }
            if (currentPosition < unformattedKey.Length)
            {
                result.Append(unformattedKey.Substring(currentPosition));
            }

            return result.ToString().ToLowerInvariant();
        }
        private string GenerateQrCodeUri(string username, string unformattedKey)
        {
            return string.Format(
                AuthenticatorUriFormat,
                _urlEncoder.Encode("TwoFactAuth"),
                _urlEncoder.Encode(username),
                unformattedKey);
        }
    }
}