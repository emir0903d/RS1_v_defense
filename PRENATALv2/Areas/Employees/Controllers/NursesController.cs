using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRENATALv2.Areas.Admin.Models;
using PRENATALv2.Areas.Home.Models;

namespace PRENATALv2.Areas.Employees.Controllers
{
    [Area("Employees")]
    [Authorize(Roles = "Doctor, doctor, Nurse, nurse")]
    [AutoValidateAntiforgeryToken]
    public class NursesController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        public NursesController(UserManager<AppUser> UserManager)
        {
            UserMgr = UserManager;
        }
        public async Task<IActionResult> Show()
        {
            List<AppUser> List = new List<AppUser>();
            List.AddRange(await UserMgr.GetUsersInRoleAsync("Nurse"));
            return View("Show", List);
        }
        public IActionResult Add()
        {
            Register model = new Register();
            model.Gender_List = new List<SelectListItem>()
            {
                new SelectListItem(){Value="Male",Text="Male"},
                new SelectListItem(){Value="Female",Text="Female"}
            };
            return View("Add", model);
        }
        public async Task<IActionResult> SaveNew(Register input)
        {

            AppUser x = new AppUser
            {
                UserName = input.Surname + input.Name.Substring(0, 1),
                Name = input.Name,
                Surname = input.Surname,
                Gender = input.Gender,
                Email = input.Email,
                PhoneNumber = input.PhoneNumber,
                Type = AppUser.UserType.Nurse,
                Status = AppUser.UserStatus.Approved,
                PhoneNumberConfirmed = true,
                EmailConfirmed = true,
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
            return RedirectToAction("Show", "Nurses");

        }
        public async Task<IActionResult> Edit(int Id)
        {
            EditUser model = new EditUser();
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
            return View("Edit", model);
        }
        public async Task<IActionResult> SaveExisting(EditUser input)
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
            await UserMgr.UpdateAsync(x);

            return RedirectToAction("Show", "Nurses");

        }
        public async Task<IActionResult> Delete(int Id)
        {
            AppUser x = await UserMgr.FindByIdAsync(Id.ToString());
            if (await UserMgr.IsInRoleAsync(x, x.Type.ToString()) == true)
            {
                await UserMgr.RemoveFromRoleAsync(x, x.Type.ToString());
            }

            await UserMgr.DeleteAsync(x);
            return RedirectToAction("Show", "Nurses");
        }
    }
}