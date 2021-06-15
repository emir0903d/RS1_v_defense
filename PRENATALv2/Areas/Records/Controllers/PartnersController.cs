using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRENATALv2.Areas.Home.Data;
using PRENATALv2.Areas.Home.Models;
using PRENATALv2.Areas.Records.Models;

namespace PRENATALv2.Areas.Records.Controllers
{
    [Area("Records")]
    [Authorize(Roles ="Patient, Doctor, Nurse")]
    [AutoValidateAntiforgeryToken]
    public class PartnersController : Controller
    {
        private Context _db { get; }
        public PartnersController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            Partners x = new Partners();
            x.MedicalRecordId = Id;
            x.ListPartners= _db.Partner.Where(a => a.MedicalRecordId == Id).Select(x=>new Partners.Details
            {
                PartnerId=x.PartnerId,
                Name=x.Name,
                Surname=x.Surname,
                BloodType=x.BloodType,
                RHFactor=x.RHFactor
            }).ToList();

            return PartialView("_Show",x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
        {
            Partners.Details x = new Partners.Details();
            x.MedicalRecordId = Id;
            x.BloodTypes = new List<SelectListItem>
            {
                new SelectListItem(){Value="A", Text="A"},
                new SelectListItem(){Value="B", Text="B"},
                new SelectListItem(){Value="0", Text="0"},
                new SelectListItem(){Value="AB", Text="AB"}
            };
            x.RhFactors = new List<SelectListItem>
            {
                new SelectListItem(){Value="+", Text="+"},
                new SelectListItem(){Value="-", Text="-"}
                
            };
            return PartialView("_Add", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(Partners.Details input)
        {

            Partner x = new Partner();
            x.Name = input.Name;
            x.Surname = input.Surname;
            x.BloodType = input.BloodType;
            x.RHFactor = input.RHFactor;
            x.MedicalRecordId = input.MedicalRecordId;
            _db.Partner.Add(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            Partners.Details x = new Partners.Details();
            Partner y = _db.Partner.Where(i => i.PartnerId == Id).SingleOrDefault();
            x.PartnerId = y.PartnerId;
            x.MedicalRecordId = y.MedicalRecordId;
            x.Name = y.Name;
            x.Surname = y.Surname;
            x.BloodType = y.BloodType;
            x.RHFactor = y.RHFactor;
            x.BloodTypes = new List<SelectListItem>
            {
                new SelectListItem(){Value="A", Text="A"},
                new SelectListItem(){Value="B", Text="B"},
                new SelectListItem(){Value="0", Text="0"},
                new SelectListItem(){Value="AB", Text="AB"}
            };
            x.RhFactors = new List<SelectListItem>
            {
                new SelectListItem(){Value="+", Text="+"},
                new SelectListItem(){Value="-", Text="-"}

            };
            return PartialView("_Edit",x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(Partners.Details input)
        {
            Partner x = _db.Partner.Where(i => i.PartnerId == input.PartnerId).SingleOrDefault();
            x.Name = input.Name;
            x.Surname = input.Surname;
            x.BloodType = input.BloodType;
            x.RHFactor = input.RHFactor;
            x.MedicalRecordId = input.MedicalRecordId;

            _db.Partner.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
        {
            Partner x = _db.Partner.Where(i => i.PartnerId == Id).SingleOrDefault();
            _db.Partner.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}