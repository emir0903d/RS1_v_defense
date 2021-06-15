using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRENATALv2.Areas.Admin.Controllers;
using PRENATALv2.Areas.Home.Models;
using PRENATALv2.Areas.Identity.Controllers;

namespace PRENATALv2.Areas.Home.Controllers
{
    [Area("Home")]
    [Authorize(Roles ="Patient, Nurse, Doctor, Admin")]
    [AutoValidateAntiforgeryToken]
    public class ProfileController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private EmailController eMail { get; }
        private SMSController sMS { get; }
        public ProfileController(UserManager<AppUser> userManager, EmailController email, SMSController sms)
        {
            UserMgr = userManager;
            eMail = email;
            sMS = sms;
        }

        public async Task<IActionResult> ShowProfile(int Id)
        {
            AppUser y = await UserMgr.FindByIdAsync(Id.ToString());
            
            _profile x = new _profile();
            x.Id = y.Id;
            x.Name = y.Name;
            x.Surname = y.Surname;
            x.Email = y.Email;
            x.PhoneNumber = y.PhoneNumber;
            x.LastLogin = y.LoginDate;
            x.RegDate = y.RegDate;
            x.LoginCount = y.LoginCount;
            x.EmailConfirmed = y.EmailConfirmed;
            x.PhoneConfirmed = y.PhoneNumberConfirmed;
            x.TwoFactor = y.TwoFactorEnabled;
            return View("Profile", x);

        }
        public async Task<IActionResult> SaveExisting(_profile input)
        {
            AppUser y = await UserMgr.FindByIdAsync(input.Id.ToString());
            if(input.Name!=y.Name || input.Surname != y.Surname)
            {
                y.UserName = input.Surname + input.Name.Substring(0, 1);
                int i = 1;
                while (UserMgr.Users.Where(id=>id.Id!=input.Id).Where(un => un.UserName == y.UserName).Any() == true)
                {
                    i++;
                    y.UserName = input.Surname + input.Name.Substring(0, i);
                }
            }
            y.Name = input.Name;
            y.Surname = input.Surname;
            y.PhoneNumber = input.PhoneNumber;
            y.Email = input.Email;
            y.PhoneNumberConfirmed = input.PhoneConfirmed;
            y.EmailConfirmed = input.EmailConfirmed;
            y.TwoFactorEnabled = input.TwoFactor;
            await UserMgr.UpdateAsync(y);

            return Redirect("/Home/Profile/ShowProfile?Id=" + input.Id);
        }
        public async Task<IActionResult> ConfEmail(int Id)
        {
            AppUser user = await UserMgr.FindByIdAsync(Id.ToString());
            var token = await UserMgr.GenerateEmailConfirmationTokenAsync(user);
           
            eMail.Send(user.Name, user.Email, token);

            _confirmEmail x = new _confirmEmail();
            x.Id = user.Id;
            x.Email = user.Email;
            return View("_ConfirmEmail", x);
        }
        public async Task<IActionResult> AttemptConfirmEmail(_confirmEmail input)
        {
            AppUser x = await UserMgr.FindByIdAsync(input.Id.ToString());
            var result = await UserMgr.ConfirmEmailAsync(x, input.Token);
            if (result.Succeeded)
            {
                if (x.Status != AppUser.UserStatus.Approved)
                {
                    x.Status = AppUser.UserStatus.Approved;
                    await UserMgr.UpdateAsync(x);
                }
            }
            return Redirect("/Home/Profile/ShowProfile?Id=" + input.Id);
        }
        public async Task<IActionResult> ConfPhone(int Id)
        {
            AppUser user = await UserMgr.FindByIdAsync(Id.ToString());
            var code = await UserMgr.GenerateChangePhoneNumberTokenAsync(user, user.PhoneNumber);
            
            _confirmPhone x = new _confirmPhone();
            x.Id = user.Id;
            x.PhoneNumber = user.PhoneNumber;
            

            sMS.Send(user.PhoneNumber, code);
            
            return View("_ConfirmPhone",x);
        }
        public async Task<IActionResult> AttemptConfirmPhone(_confirmPhone input)
        {
            AppUser x =await UserMgr.FindByIdAsync(input.Id.ToString());
            await UserMgr.ChangePhoneNumberAsync(x, input.PhoneNumber, input.Code);
            return Redirect("/Home/Profile/ShowProfile?Id=" + input.Id);
        }
        //public async Task<IActionResult> Add2FA(int Id)
        //{
        //    //AppUser user = await UserMgr.FindByIdAsync(Id.ToString());
        //    //var unformattedKey = await UserMgr.GetAuthenticatorKeyAsync(user);
        //    //if (string.IsNullOrEmpty(unformattedKey))
        //    //{
        //    //    await UserMgr.ResetAuthenticatorKeyAsync(user);
        //    //    unformattedKey = await UserMgr.GetAuthenticatorKeyAsync(user);
        //    //}
        //    //_2FA model = new _2FA();
        //    //model.Provider = await UserMgr.RegisterTokenProvider("GOOGLE", user);
        //    //model.SharedKey = unformattedKey;
        //    //model.Id = Id;


        //    return View("_add2FA", model);
        //}
        //public async Task<IActionResult> AttemptAdd2FA(_2FA input)
        //{
        //    AppUser user = await UserMgr.FindByIdAsync(input.Id);
        //    await UserMgr.VerifyTwoFactorTokenAsync(user,)
        //}
    }
}