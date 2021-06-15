using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRENATALv2.Areas.Home.Data;
using PRENATALv2.Areas.Home.Models;
using PRENATALv2.Areas.Records.Models;

namespace PRENATALv2.Areas.Records.Controllers
{
    [Area("Records")]
    [Authorize(Roles = "Patient, Doctor, Nurse")]
    [AutoValidateAntiforgeryToken]
    public class AllergiesController : Controller
    {
        private Context _db { get; }
        public AllergiesController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            AllergiesMR x = new AllergiesMR();
            x.MedicalRecordId = Id;
            x.AllergyList = _db.Allergies.Where(a => a.MedicalRecordId == Id).Select(x => new AllergiesMR.Details
            {
               Id=x.AllergiesId,
               Type=x.Type,
               Note=x.Note
            }).ToList();

            return PartialView("_Show", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
        {
            AllergiesMR.Details x = new AllergiesMR.Details();
            x.MedicalRecordId = Id;       
            return PartialView("_Add", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(AllergiesMR.Details input)
        {

            Allergies x = new Allergies();
            x.Type = input.Type;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;
            _db.Allergies.Add(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            AllergiesMR.Details x = new AllergiesMR.Details();
            Allergies y = _db.Allergies.Where(i=>i.AllergiesId==Id).SingleOrDefault();
            
            x.Id = y.AllergiesId;
            x.MedicalRecordId = y.MedicalRecordId;
            x.Type = y.Type;
            x.Note = y.Note;
            
            return PartialView("_Edit", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(AllergiesMR.Details input)
        {
            Allergies x = _db.Allergies.Where(i => i.AllergiesId == input.Id).SingleOrDefault();
            x.Type = input.Type;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;

            _db.Allergies.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
        {
            Allergies x = _db.Allergies.Where(i => i.AllergiesId == Id).SingleOrDefault();
            _db.Allergies.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}