using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRENATALv2.Areas.Home.Data;
using PRENATALv2.Areas.Home.Models;

using System.Web;
namespace PRENATALv2.Areas.Home.Controllers
{

    [Authorize(Roles = "Patient")]
    [Area("Home")]
    [AutoValidateAntiforgeryToken]
    public class ChartsController : Controller
    {
        private Context _db { get; }


        public ChartsController(Context context)
        {
            _db = context;

        }
        public IActionResult VitalSigns(int Id)
        {

            return View("VitalSigns", Id);
        }
        public JsonResult GetVitalSigns(int Id)
        {
            var VitalSigns = _db.VitalSigns.Where(id => id.MedicalRecordId == Id).Select(x => new VSdata
            {
                Date = x.Date,
                Temperature = x.Temperature,
                SystolicPressure = x.SystolicPressure,
                DiastolicPressure = x.DiastolicPressure,
                HeartBeats = x.HeartBeats,
                RespiratoryRate = x.RespiratoryRate,
                Weight = x.Weight

            }).ToList();
            return Json(VitalSigns);
        }
        //public JsonResult GetVSdata(int Id)
        //{
        //    List<VSdata> data = new List<VSdata>();

        //    data = _db.VitalSigns.Where(i => i.MedicalRecordId == Id).Select(x=>new VSdata
        //    {
        //        Date=x.Date,
        //        Temperature=x.Temperature,
        //        SystolicPressure=x.SystolicPressure,
        //        DiastolicPressure=x.DiastolicPressure,
        //        HeartBeats=x.HeartBeats,
        //        RespiratoryRate=x.RespiratoryRate,
        //        Height=x.Height,
        //        Weight=x.Weight

        //    }).ToList();
        //    var chartData = new object[data.Count + 1];
        //    chartData[0] = new object[]{
        //        "Date",
        //        "Temperature",
        //        "SystolicPressure",
        //        "DiastolicPressure",
        //        "HeartBeats",
        //        "RespiratoryRate",
        //        "Height",
        //        "Weight"
        //    };

        //    int j = 0;
        //    foreach (var i in data)
        //    {
        //        j++;
        //        chartData[j] = new object[] { i.Date.ToString(), i.Temperature.ToString(), i.SystolicPressure.ToString(), i.DiastolicPressure.ToString(), i.HeartBeats.ToString(), i.RespiratoryRate.ToString(), i.Height.ToString(), i.Weight.ToString() };
        //    }
        //    return new JsonResult(chartData);
        //}
    }
        
}