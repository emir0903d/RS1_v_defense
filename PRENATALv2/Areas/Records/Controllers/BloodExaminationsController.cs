using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRENATALv2.Areas.Home.Models;
using PRENATALv2.Areas.Records.Models;

namespace PRENATALv2.Areas.Records.Controllers
{
    [Area("Records")]
    [Authorize(Roles = "Patient, Doctor, Nurse")]
    [AutoValidateAntiforgeryToken]
    public class BloodExaminationsController : Controller
    {
        private Context _db { get; }
        public BloodExaminationsController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            return View();
        }
    }
}