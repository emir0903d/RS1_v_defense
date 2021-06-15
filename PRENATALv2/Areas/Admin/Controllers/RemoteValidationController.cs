using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using PRENATALv2.Areas.Home.Models;

namespace PRENATALv2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    [AutoValidateAntiforgeryToken]
    public class RemoteValidationController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private Context _db { get; }
        public RemoteValidationController(UserManager<AppUser> UserManager, Context context)
        {
            UserMgr = UserManager;
            _db = context;
        }
        [AllowAnonymous]
        //[IgnoreAntiforgeryTokenAttribute]
        [AcceptVerbs("POST", "GET")]
        [ValidateAntiForgeryToken]
        public JsonResult IsEmailTaken(string Email, int Id)//Registracija???Edit!OK
        {
            bool status = true;
            
            if(UserMgr.Users.Where(i=>i.Id!=Id).Where(m => m.Email == Email).Any())
            {
                status = false;
            }
            return Json(status);

        }
        [AllowAnonymous]
        [AcceptVerbs("POST","GET")]
        //[IgnoreAntiforgeryTokenAttribute]
        [ValidateAntiForgeryToken]
        public JsonResult IsPhoneNumberTaken(string PhoneNumber, int Id)//Registracija??? Edit!OK
        {
            bool status = true;
                      
            if (UserMgr.Users.Where(i => i.Id != Id).Where(m => m.PhoneNumber == PhoneNumber).Any())
            {
                status = false;
            }
            return Json(status);

        }
        [AllowAnonymous]
        [AcceptVerbs("POST", "GET")]
        //[IgnoreAntiforgeryTokenAttribute]
        [ValidateAntiForgeryToken]
        public JsonResult IsPINTaken(string PersonalIdentificationNumber, int Id)
        {
            bool status = true;

            if (_db.MedicalRecord.Where(i=>i.MedicalRecordId!=Id).Where(m => m.PersonalIdentificationNumber == PersonalIdentificationNumber).Any())
            {
                status = false;
            }
            return Json(status);
        }
        public async Task<JsonResult> IsPasswordCorrect(string _currentPassword, int? UserId)
        {
            bool status = false;
            AppUser u = await UserMgr.FindByIdAsync(UserId.ToString());
            if (await UserMgr.CheckPasswordAsync(u, _currentPassword))
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return Json(status);
        }
        public JsonResult ArePasswordsTheSame(string _confirmPassword, string _newPassword)
        {
            bool status = false;
            if (_newPassword == _confirmPassword)
            {
                status = true;
            }
            else
            {
                status = false;
            }
            return Json(status);
        }
    }

}  