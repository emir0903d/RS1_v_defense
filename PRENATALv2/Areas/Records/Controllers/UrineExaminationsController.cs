using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PRENATALv2.Areas.Records.Controllers
{
    public class UrineExaminationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}