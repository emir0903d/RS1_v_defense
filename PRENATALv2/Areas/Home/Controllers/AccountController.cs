using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRENATALv2.Areas.Admin.Controllers;
using PRENATALv2.Areas.Home.Models;

namespace PRENATALv2.Areas.Identity.Controllers
{
    [Area("Home")]
    [AllowAnonymous]
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInMgr { get; }
        private SMSController Sms { get; }
        private EmailController Email { get; }
        private Context _db { get; }
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, SMSController sMSController, EmailController eMail, Context context)
        {
            UserMgr = userManager;
            SignInMgr = signInManager;
            Sms = sMSController;
            Email = eMail;
            _db = context;
        }
        public IActionResult ChangePassword(int Id)
        {
            _changePwd x = new _changePwd()
            {
                UserId = Id
            };
            return View("ChangePWD", x);
        }

        public async Task<IActionResult> AttemptChangePwd(_changePwd input)
        {
            if (input.UserId == null || input._confirmPassword == null || input._newPassword==null || input._currentPassword==null)
            {
                return Redirect("AccessDenied");
            }
            AppUser user = await UserMgr.FindByIdAsync(input.UserId.ToString());
            await UserMgr.ChangePasswordAsync(user, input._currentPassword, input._newPassword);

            return RedirectToAction("Login","Account");
        }

        public IActionResult Login()
        {
            return View("Login");
        }
        public async Task<IActionResult> LoginAttempt(Login input)
        {
            if (input.Username == null || input.Password==null)
            {
                return Redirect("AccessDenied");
            }
            AppUser user = await UserMgr.FindByNameAsync(input.Username);
            
            if (user != null)
            {
                var signInResult = await SignInMgr.PasswordSignInAsync(user, input.Password, false, false);
                if (signInResult.RequiresTwoFactor)
                {
                    return RedirectToAction("Start2FA", "Account");
                }
                if (signInResult.Succeeded)
                {
                    user.LoginCount++;
                    user.LoginDate = DateTime.Now;
                    await UserMgr.UpdateAsync(user);

                    if(user.Type != AppUser.UserType.Admin && user.LoginCount <= 1)
                    {
                        return RedirectToAction("ChangePassword", new { user.Id });
                    }

                    return RedirectToAction("FrontPage", "Home");
                }
                if (signInResult.IsNotAllowed)
                {
                    ViewBag.Msg = "Your account is not approved. Please check your email and verify your account!";
                    return View("Message");
                }
            }
            return RedirectToAction("Register", "Account");
        }
        public async Task<IActionResult> Start2FA()
        {
            // Ensure the user has gone through the username & password screen first
            AppUser user = await SignInMgr.GetTwoFactorAuthenticationUserAsync();

            if (user == null)
            {
                throw new ApplicationException($"Unable to load two-factor authentication user.");
            }

            return View("Start2FA");
        }
        public async Task<IActionResult> Attempt2FAlogin(_2FAlogin model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            AppUser user = await SignInMgr.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new ApplicationException($"Unable to load user with ID '{UserMgr.GetUserId(User)}'.");
            }

            var authenticatorCode = model.TwoFactorCode.Replace(" ", string.Empty).Replace("-", string.Empty);

            var result = await SignInMgr.TwoFactorAuthenticatorSignInAsync(authenticatorCode, false, model.RememberClient);

            if (result.Succeeded)
            {
                user.LoginCount++;
                user.LoginDate = DateTime.Now;
                await UserMgr.UpdateAsync(user);

                if (user.Type != AppUser.UserType.Admin && user.LoginCount == 1)
                {
                    ChangePassword(user.Id);
                }

                return RedirectToAction("FrontPage", "Home");
            }
            return RedirectToAction("Register", "Account");

        }
        public async Task<IActionResult> RecoveryCodeLogin()
        {
            AppUser user = await SignInMgr.GetTwoFactorAuthenticationUserAsync();
            if (user != null)
            {
                return View("RecoveryCodeLogin");
            }
            return RedirectToAction("Register", "Account");

        }

        public async Task<IActionResult> AttemptRecoveryCodeLogin(_recoveryCodeLogin model)
        {
            
            AppUser user = await SignInMgr.GetTwoFactorAuthenticationUserAsync();
            if (user == null)
            {
                throw new ApplicationException($"Unable to load two-factor authentication user.");
            }

            var recoveryCode = model.RecoveryCode.Replace(" ", string.Empty);

            var result = await SignInMgr.TwoFactorRecoveryCodeSignInAsync(recoveryCode);

            if (result.Succeeded)
            {
                user.LoginCount++;
                user.LoginDate = DateTime.Now;
                await UserMgr.UpdateAsync(user);

                if (user.Type != AppUser.UserType.Admin && user.LoginCount == 1)
                {
                    ChangePassword(user.Id);
                }

                return RedirectToAction("FrontPage", "Home");
            }
            return RedirectToAction("Register", "Account");
        }
        public IActionResult Register()
        {
            Register model = new Register();
            model.Gender_List = new List<SelectListItem>()
            {
                new SelectListItem(){Value="Male",Text="Male"},
                new SelectListItem(){Value="Female",Text="Female"}
            };
            model.Type_List = new List<SelectListItem>()
            {
                new SelectListItem(){Value="1", Text="Doctor"},
                new SelectListItem(){Value="2", Text="Nurse"},
                new SelectListItem(){Value="3", Text="Patient"}
            };
            model.Doctors = UserMgr.Users
                .Where(a => a.Status == AppUser.UserStatus.Approved)
                .Where(b => b.Type == AppUser.UserType.Doctor)
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name + " " + x.Surname
                }).ToList();
            return View("Register", model);
        }


        public async Task<IActionResult> RegisterAttempt(Register input)
        {
            AppUser user = new AppUser
            {
                UserName = input.Surname + input.Name.Substring(0, 1),
                Email = input.Email,
                PhoneNumber = input.PhoneNumber,
                Name = input.Name,
                Surname = input.Surname,
                Gender = input.Gender,
                Status = AppUser.UserStatus.Rejected,
                Type = input.Type,
                SecurityStamp=Guid.NewGuid().ToString(),//
                RegDate=DateTime.Now,
                LoginCount=0
                
            };

            int i = 1;
            while (UserMgr.Users.Where(un => un.UserName == user.UserName).Any() == true)
            {
                i++;
                user.UserName = input.Surname + input.Name.Substring(0, i);
            }

            if (user.Type==AppUser.UserType.Patient && input.DoctorId != null)
            {
                user.DoctorId = input.DoctorId;
            }
            
            string _pwd = GeneratePassword();
            var result = await UserMgr.CreateAsync(user, _pwd);
            if (result.Succeeded)
            {
                SendCredentials(user, _pwd);
            }
            


            if (user.Type == AppUser.UserType.Doctor)
            {
                await UserMgr.AddToRoleAsync(user, "Doctor");
            }
            if (user.Type == AppUser.UserType.Nurse)
            {
                await UserMgr.AddToRoleAsync(user, "Nurse");
            }
            if (user.Type == AppUser.UserType.Patient)
            {
                await UserMgr.AddToRoleAsync(user, "Patient");
            }

            SendEmailToken(user);
            //SendPhoneToken(user);          

            return Redirect("/Home/Account/Login");
        }
        public void SendCredentials(AppUser user, string password)
        {
            string txt = "Hello, " + user.Name + 
                ", \n username: " + user.UserName + 
                ",\n password: " + password + 
                "\n Please change your password on your first visit!";

            Email.Send(user.Name + " " + user.Surname, user.Email, txt);
        }
        public async void SendEmailToken(AppUser user)
        {
            var email_token = await UserMgr.GenerateEmailConfirmationTokenAsync(user);
            var confirmation_url = Url.ActionLink("AttemptConfirmEmail", "Account", new { Id = user.Id, token = email_token, Request.Scheme });
            if(Email.Send(user.Name, user.Email, confirmation_url) == true)
            {
                ViewBag.EmailMsg = "Confirmation E-mail sent to: " + user.Email; 
            }
     
        }
        public async Task<IActionResult> AttemptConfirmEmail(int? Id, string token) {
            if(Id==null || token == null)
            {
                ViewBag.Msg = "Confirmation link is not valid!";
                return View("Message");
            }
            AppUser user = await UserMgr.FindByIdAsync(Id.ToString());
            if (user == null)
            {
                ViewBag.Msg = "User doesn't exist!";
                return View("Message");
            }
            var result = await UserMgr.ConfirmEmailAsync(user, token);
            if (result.Succeeded)
            {
                ViewBag.Msg = "Successfully confirmed Email! \n Account approved!";
                AppUser x = await UserMgr.FindByNameAsync(user.UserName);
                x.Status = AppUser.UserStatus.Approved;
                return View("Message");
            }
            ViewBag.Msg = "Email cannot be confirmed!";
            return View("Message");
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }
        //private string GenerateRandomPassword(bool useLowercase, bool useUppercase, bool useNumbers, bool useSpecial,
        //int passwordSize)
        //{
        //    const string LOWER_CASE = "abcdefghijklmnopqursuvwxyz";
        //    const string UPPER_CAES = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    const string NUMBERS = "123456789";
        //    const string SPECIALS = @"!@£$%^&*()#€";
        //    char[] _password = new char[passwordSize];
        //    string charSet = "";

        //    Random _random = new Random();
        //    int counter;

        //    if (useLowercase) charSet += LOWER_CASE;

        //    if (useUppercase) charSet += UPPER_CAES;

        //    if (useNumbers) charSet += NUMBERS;

        //    if (useSpecial) charSet += SPECIALS;

        //    for (counter = 0; counter < passwordSize; counter++)
        //    {
        //        _password[counter] = charSet[_random.Next(charSet.Length - 1)];
        //    }

        //    return String.Join(null, _password);
        //}
        public string GeneratePassword()
        {
            var options = UserMgr.Options.Password;

            int length = options.RequiredLength;

            bool nonAlphanumeric = options.RequireNonAlphanumeric;
            bool digit = options.RequireDigit;
            bool lowercase = options.RequireLowercase;
            bool uppercase = options.RequireUppercase;

            StringBuilder password = new StringBuilder();
            Random random = new Random();

            while (password.Length < length)
            {
                char c = (char)random.Next(32, 126);

                password.Append(c);

                if (char.IsDigit(c))
                    digit = false;
                else if (char.IsLower(c))
                    lowercase = false;
                else if (char.IsUpper(c))
                    uppercase = false;
                else if (!char.IsLetterOrDigit(c))
                    nonAlphanumeric = false;
            }

            if (nonAlphanumeric)
                password.Append((char)random.Next(33, 47));
            if (digit)
                password.Append((char)random.Next(48, 57));
            if (lowercase)
                password.Append((char)random.Next(97, 122));
            if (uppercase)
                password.Append((char)random.Next(65, 90));

            return password.ToString();
        }

    }
}