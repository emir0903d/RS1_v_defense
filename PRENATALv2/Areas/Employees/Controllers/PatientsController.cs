using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRENATALv2.Areas.Admin.Models;
using PRENATALv2.Areas.Employees.Models;
using PRENATALv2.Areas.Home.Data;
using PRENATALv2.Areas.Home.Models;

namespace PRENATALv2.Areas.Employees.Controllers
{
    [Area("Employees")]
    [Authorize(Roles = "Doctor, doctor, Nurse, nurse")]
    [AutoValidateAntiforgeryToken]
    public class PatientsController : Controller
    {
        private Context _db { get; }
        private UserManager<AppUser> UserMgr { get; }
        public PatientsController(UserManager<AppUser> UserManager, Context context)
        {
            _db = context;
            UserMgr = UserManager;
        }
        public IActionResult Show()
        {
            List<Patient> List = UserMgr.Users.Where(a => a.Status == AppUser.UserStatus.Approved)
                .Where(a => a.Type == AppUser.UserType.Patient).Select(x => new Patient
                {
                    Id = x.Id,
                    Name = x.Name,
                    Surname = x.Surname,
                    UserName=x.UserName,
                    PhoneNumber = x.PhoneNumber,
                    Email = x.Email,
                    Gender = x.Gender,
                    DoctorId = x.DoctorId,
                    Doctor = UserMgr.Users
                    .Where(a => a.Id == x.DoctorId).SingleOrDefault().Name + " " +
                    UserMgr.Users.Where(a => a.Id == x.DoctorId).SingleOrDefault().Surname,
                    MedicalRecordNumber = _db.MedicalRecord.Where(a => a.MedicalRecordId == x.Id).SingleOrDefault().MedicalRecordNumber
                }).ToList();
            
            return View("Show", List);
        }
        public IActionResult Add()
        {
            Patient model = new Patient();
            model.Gender_List = new List<SelectListItem>()
            {
                new SelectListItem(){Value="Male",Text="Male"},
                new SelectListItem(){Value="Female",Text="Female"}
            };
            model.Doctors = UserMgr.Users
                .Where(a=>a.Status==AppUser.UserStatus.Approved)
                .Where(b=>b.Type==AppUser.UserType.Doctor)
                .Select(x => new SelectListItem
            {
                Value= x.Id.ToString(),
                Text = x.Name +" "+ x.Surname
            }).ToList();

            return View("Add", model);
        }
        public async Task<IActionResult> SaveNew(Patient input)
        {

            AppUser x = new AppUser
            {
                UserName = input.Surname + input.Name.Substring(0, 1),
                Name = input.Name,
                Surname = input.Surname,
                Gender = input.Gender,
                Email = input.Email,
                PhoneNumber = input.PhoneNumber,
                Type = AppUser.UserType.Patient,
                Status = AppUser.UserStatus.Approved,
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
                DoctorId =input.DoctorId,
                SecurityStamp = Guid.NewGuid().ToString(),
                RegDate = DateTime.Now,
                LoginCount = 0

            };


            int i = 1;
            while (UserMgr.Users.Where(un => un.UserName == x.UserName).Any() == true)
            {
                i++;
                x.UserName = input.Surname + input.Name.Substring(0, i);
            }

            await UserMgr.CreateAsync(x, "Pp!12345");
            await UserMgr.AddToRoleAsync(x, x.Type.ToString());
            return RedirectToAction("Show", "Patients");

        }
        public async Task<IActionResult> Edit(int Id)
        {
            Patient model = new Patient();
            AppUser x = await UserMgr.FindByIdAsync(Id.ToString());
            model.Id = x.Id;
            model.UserName = x.UserName;
            model.Name = x.Name;
            model.Surname = x.Surname;
            model.Email = x.Email;
            model.PhoneNumber = x.PhoneNumber;
            model.Gender = x.Gender;
            model.Gender_List = new List<SelectListItem>
            {
                new SelectListItem(){Value="Male",Text="Male"},
                new SelectListItem(){Value="Female",Text="Female"}
            };
            model.Doctors = UserMgr.Users.Where(a => a.Status == AppUser.UserStatus.Approved)
                .Where(b => b.Type == AppUser.UserType.Doctor)
                .Select(d => new SelectListItem
                {
                    Value = d.Id.ToString(),
                    Text = d.Name + " " + d.Surname
                }).ToList();

            return View("Edit", model);
        }
        public async Task<IActionResult> SaveExisting(Patient input)
        {
            AppUser x = await UserMgr.FindByIdAsync(input.Id.ToString());
            if (x.Name != input.Name || x.Surname != input.Surname)
            {
                int i = 1;
                x.UserName = input.Surname + input.Name.Substring(0, i);
                while (UserMgr.Users.Where(un => un.UserName == x.UserName).Any() == true)
                {
                    i++;
                    x.UserName = input.Surname + input.Name.Substring(0, i);
                }
            }
            x.Name = input.Name;
            x.Surname = input.Surname;
            x.Email = input.Email;
            x.PhoneNumber = input.PhoneNumber;
            x.Gender = input.Gender;
            x.DoctorId = input.DoctorId;
            
            await UserMgr.UpdateAsync(x);
            return RedirectToAction("Show", "Patients");

        }
        public async Task<IActionResult> Delete(int Id)
        {
            AppUser x = await UserMgr.FindByIdAsync(Id.ToString());
            if (await UserMgr.IsInRoleAsync(x, x.Type.ToString()) == true)
            {
                await UserMgr.RemoveFromRoleAsync(x, x.Type.ToString());
            }
            //Delete all records???
           
            MedicalRecord xx = _db.MedicalRecord.Find(Id);
            if (xx != null)
            {
                _db.MedicalRecord.Remove(xx);
                _db.SaveChanges();

            }
      

            await UserMgr.DeleteAsync(x);
            _db.Dispose();
            return RedirectToAction("Show", "Patients");
        }
    }
}