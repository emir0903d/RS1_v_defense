using Microsoft.AspNetCore.Identity;
using PRENATALv2.Areas.Home.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2
{
    public class Init
    {
        public static async Task AssignAdmin(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            await CreateRoles(roleManager);
            await CreateAdminUser(userManager);

            AppUser admin = await userManager.FindByEmailAsync("prenatal.sa@gmail.com");
            await userManager.AddPasswordAsync(admin, "Admin!12");

            if (await userManager.IsInRoleAsync(admin, "Admin")==false)
            {
                await userManager.AddToRoleAsync(admin, "Admin");

            }
    
        }
        private static async Task CreateRoles(RoleManager<AppRole> roleManager)
        {
            if (await roleManager.FindByNameAsync("Admin")==null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }
            if (await roleManager.FindByNameAsync("Doctor") == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Doctor" });
            }
            if (await roleManager.FindByNameAsync("Nurse") == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Nurse" });
            }
            if (await roleManager.FindByNameAsync("Patient") == null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Patient" });
            }
        }
        private static async Task CreateAdminUser(UserManager<AppUser> userManager)
        {
            if (await userManager.FindByEmailAsync("prenatal.sa@gmail.com") == null)
            {
                 await userManager.CreateAsync(new AppUser
                {
                    Name = "Admin",
                    Surname = "Admin",
                    UserName = "admin",
                    Gender=null,
                    Email = "prenatal.sa@gmail.com",
                    EmailConfirmed=true,
                    PhoneNumber="+38761777888",
                    PhoneNumberConfirmed=true,
                    Status=AppUser.UserStatus.Approved,
                    Type=AppUser.UserType.Admin,
                    SecurityStamp= Guid.NewGuid().ToString(),
                    RegDate =DateTime.Now,
                    LoginCount=0
                    
                });
                
            }

        }
        
    }
}
