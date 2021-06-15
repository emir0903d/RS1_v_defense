using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRENATALv2.Areas.Employees.Models;
using PRENATALv2.Areas.Home.Models;

namespace PRENATALv2.Areas.Employees.Controllers
{
    [Area("Employees")]
    [Authorize (Roles = "Doctor, Nurse, Patient")]
    [AutoValidateAntiforgeryToken]
    public class AppointmentsController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private Context _db { get; set; }
        public AppointmentsController(UserManager<AppUser> userManager, Context context)
        {
            UserMgr = userManager;
            _db = context;
        }
        public IActionResult Show()
        {
            Appointments x = new Appointments();
            x.Doctors = _db.Users.Where(t => t.Type == AppUser.UserType.Doctor).Select(x => new SelectListItem
            {
                Value=x.Id.ToString(),
                Text=x.Name+" "+x.Surname
            }).ToList();

            return View("Show",x);
        }
    }
}