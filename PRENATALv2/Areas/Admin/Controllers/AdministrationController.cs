using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PRENATALv2.Areas.Admin.Models;
using PRENATALv2.Areas.Home.Models;
using System.Web;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Differencing;

namespace PRENATALv2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, admin")]
    [AutoValidateAntiforgeryToken]
    public class AdministrationController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private RoleManager<AppRole> RoleMgr { get; }
        public AdministrationController(RoleManager<AppRole> RoleManager, UserManager<AppUser> UserManager)
        {
            RoleMgr = RoleManager;
            UserMgr = UserManager;
        }


        public async Task<IActionResult> ShowRoles()
        {
            List<AppRole> roles = RoleMgr.Roles.Where(n=>n.Name!="Admin").ToList();
            

            foreach(AppRole x in roles)
            {
                List<AppUser> List_Users = new List<AppUser>();
                List_Users.AddRange(await UserMgr.GetUsersInRoleAsync(x.Name));
                x.NumberOfUsers = List_Users.Count();
            }
            return View("ShowRoles", roles);
        }

        public IActionResult CreateRole()
        {
            return View("CreateRole");
        }

        public async Task<IActionResult> AttemptCreateRole(CreateRole input)
        {
            if (ModelState.IsValid)
            {
                AppRole identityRole = new AppRole();
                identityRole.Name = input.RoleName;

                await RoleMgr.CreateAsync(identityRole);
                return RedirectToAction("ShowRoles", "Administration");
               
            }
            return View("ErrorMsg");
        }


        public async Task<IActionResult> EditRole(int RoleId)
        {
            AppRole role = await RoleMgr.FindByIdAsync(RoleId.ToString());

            EditRole model = new EditRole
            {
                Id = role.Id,
                RoleName = role.Name,
                ListOfUsers = new List<AppUser>()
            };

            foreach (AppUser x in UserMgr.Users)
            {
                if (await UserMgr.IsInRoleAsync(x, role.Name) == true)
                {
                    model.ListOfUsers.Add(x);
                }
            }
            return View("EditRole", model);

        }


        public async Task<IActionResult> SaveExistingRole(EditRole input)
        {
            AppRole role = await RoleMgr.FindByIdAsync(input.Id.ToString());
            role.Name = input.RoleName;
            var result = await RoleMgr.UpdateAsync(role);

            if (result.Succeeded)
            {
                return RedirectToAction("ShowRoles", "Administration");
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }
            return RedirectToAction("ShowRoles", "Administration");
        }


        public async Task<IActionResult> EditUsersInRole(int RoleId)
        {

            AppRole role = await RoleMgr.FindByIdAsync(RoleId.ToString());

            List<UserRole> model = new List<UserRole>();
            foreach (AppUser user in UserMgr.Users)
            {
                var userRole = new UserRole();
                userRole.UserId = user.Id;
                userRole.UserName = user.UserName;
                userRole.FirstName = user.Name;
                userRole.LastName = user.Surname;
                userRole.RoleId = role.Id;

                if (await UserMgr.IsInRoleAsync(user, role.Name))
                {
                    userRole.IsSelected = true;
                }
                else
                {
                    userRole.IsSelected = false;
                }
                model.Add(userRole);
            }
            return View("EditUsersInRole", model);
        }


        public async Task<IActionResult> AttemptEditUsersInRole(List<UserRole> input)
        {
            int ri = 0;
            foreach (UserRole x in input)
            {
                AppUser user = await UserMgr.FindByIdAsync(x.UserId.ToString());
                AppRole role = await RoleMgr.FindByIdAsync(x.RoleId.ToString());
                ri = role.Id;

                if (x.IsSelected == true && !(await UserMgr.IsInRoleAsync(user, role.Name)))
                {
                    await UserMgr.AddToRoleAsync(user, role.Name);
                }
                if (x.IsSelected == false && await UserMgr.IsInRoleAsync(user, role.Name))
                {
                    await UserMgr.RemoveFromRoleAsync(user, role.Name);
                }

            }
            return Redirect("/Admin/Administration/EditRole?RoleId=" + ri);
        }

        public async Task<IActionResult> DeleteRole(int RoleId)
        {

            AppRole role = await RoleMgr.FindByIdAsync(RoleId.ToString());
            if(role.Name=="Admin" || role.Name == "Admin")
            {
                return Redirect("AccessDenied");
            }
            List<AppUser> List_Users = new List<AppUser>();
            List_Users.AddRange(await UserMgr.GetUsersInRoleAsync(role.Name));
            foreach(AppUser x in List_Users)
            {
                await UserMgr.RemoveFromRoleAsync(x, role.Name);
                x.Type = AppUser.UserType.Pending;
                x.Status = AppUser.UserStatus.Rejected;
                x.PhoneNumberConfirmed = false;
                x.EmailConfirmed = false;
            }
            await RoleMgr.DeleteAsync(role);
            return RedirectToAction("ShowRoles", "Administration");
        }
        public IActionResult ShowUsers()
        {
            List<AppUser> List_users = UserMgr.Users.Where(n=>n.Type!=AppUser.UserType.Admin).ToList();
            return View("ShowUsers", List_users);
        }
        public async Task<IActionResult> ApproveReject(int UserId)
        {
            AppUser x = await UserMgr.FindByIdAsync(UserId.ToString());

            if (x.Status == AppUser.UserStatus.Approved)
            {
                x.Status = AppUser.UserStatus.Rejected;
                x.EmailConfirmed = false;
                x.PhoneNumberConfirmed = false;
                
                
            }
            else 
            {
                x.Status = AppUser.UserStatus.Approved;
                x.EmailConfirmed = true;
                x.PhoneNumberConfirmed = true;
            }
            await UserMgr.UpdateAsync(x);
           
            List<AppUser> List_users = UserMgr.Users.Where(n => n.Type != AppUser.UserType.Admin).ToList();
            return View("ShowUsers", List_users);

        }
        public IActionResult AddUser()
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
            return View("AddUser",model);
        }
        public async Task<IActionResult> SaveNewUser(Register input)
        {
            if (await UserMgr.FindByEmailAsync(input.Email) == null)
            {
                if (UserMgr.Users.Where(n => n.PhoneNumber == input.PhoneNumber).Any())
                {
                    return View("AlreadyExists");
                }
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
                    SecurityStamp= Guid.NewGuid().ToString(),
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
                await UserMgr.CreateAsync(user, "Pp!12345");
                        if (await RoleMgr.RoleExistsAsync(user.Type.ToString()) == false)
                        {
                            AppRole y = new AppRole();
                            y.Name = user.Type.ToString();
                            await RoleMgr.CreateAsync(y);
                        }
                await UserMgr.AddToRoleAsync(user, user.Type.ToString());

                    return RedirectToAction("ShowUsers", "Administration");
            }
            return View("AlreadyExists");
        }
        public async Task<IActionResult> DeleteUser(int UserId)
        {


            AppUser x = await UserMgr.FindByIdAsync(UserId.ToString());
            if(x.UserName=="admin" || x.UserName == "Admin")
            {
                return Redirect("AccessDenied");
            }
            if (await UserMgr.IsInRoleAsync(x, x.Type.ToString())==true){
                await UserMgr.RemoveFromRoleAsync(x, x.Type.ToString());
            }
            if(await UserMgr.GetTwoFactorEnabledAsync(x))
            {                
                await UserMgr.RemoveAuthenticationTokenAsync(x, "[AspNetUserStore]", "AuthenticatorKey");
                await UserMgr.RemoveAuthenticationTokenAsync(x, "[AspNetUserStore]", "RecoveryCodes");
            }
            await UserMgr.DeleteAsync(x);
            return RedirectToAction("ShowUsers", "Administration");
        }
        public async Task<IActionResult> EditUser(int UserId)
        {
            EditUser model = new EditUser();
            AppUser x = await UserMgr.FindByIdAsync(UserId.ToString());
            model.Id = x.Id;
            model.UserName = x.UserName;
            model.Name = x.Name;
            model.Surname = x.Surname;
            model.EmailConfirmed = x.EmailConfirmed;
            model.Email = x.Email;
            model.PhoneNumberConfirmed = x.PhoneNumberConfirmed;
            model.PhoneNumber = x.PhoneNumber;
            model.Gender = x.Gender;
            model.Gender_List = new List<SelectListItem>
            {
                new SelectListItem(){Value="Male",Text="Male"},
                new SelectListItem(){Value="Female",Text="Female"}
            };
            model.Type = x.Type;
            model.Type_List = new List<SelectListItem>
            {
                new SelectListItem(){Value="0",Text="Admin"},
                new SelectListItem(){Value="1",Text="Doctor"},
                new SelectListItem(){Value="2",Text="Nurse"},
                new SelectListItem(){Value="3",Text="Patient"},
                new SelectListItem(){Value="4",Text="Pending"}
            };
            model.Doctors = UserMgr.Users
                .Where(a => a.Status == AppUser.UserStatus.Approved)
                .Where(b => b.Type == AppUser.UserType.Doctor)
                .Select(x => new SelectListItem
                {
                    Value = x.Id.ToString(),
                    Text = x.Name + " " + x.Surname
                }).ToList();
            return View("EditUser", model);

        }
        public async Task<IActionResult> SaveExistingUser (EditUser input)
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
            x.EmailConfirmed = input.EmailConfirmed;
            x.PhoneNumber = input.PhoneNumber;
            x.PhoneNumberConfirmed = input.PhoneNumberConfirmed;
            x.Gender = input.Gender;
            x.DoctorId = input.DoctorId;
            if (x.Type != input.Type)
            {
                if (await RoleMgr.RoleExistsAsync(input.Type.ToString())==false)
                {
                    AppRole y = new AppRole();
                    y.Name = input.Type.ToString();
                    await RoleMgr.CreateAsync(y);
                }
                if (await RoleMgr.RoleExistsAsync(x.Type.ToString()) == false)
                {
                    
                    x.Type = input.Type;
                }
                else
                {
                    await UserMgr.RemoveFromRoleAsync(x, x.Type.ToString());
                    x.Type = input.Type;
                }
                           
                await UserMgr.AddToRoleAsync(x, x.Type.ToString());
            }
            

            await UserMgr.UpdateAsync(x);


            return RedirectToAction("ShowUsers", "Administration");


        }
        public IActionResult AccessDenied()
        {
            return View("AccessDenied");
        }
    }
}