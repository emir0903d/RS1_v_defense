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
    public class TherapiesController : Controller
    {
        private Context _db { get; }
        public TherapiesController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            TherapiesMR x = new TherapiesMR();
            x.MedicalRecordId = Id;
            x.Therapies = _db.Therapies.Where(a => a.MedicalRecordId == Id).Select(x => new TherapiesMR.Details
            {
                Id = x.TherapiesId,
                BeginningDate=x.BeginningDate,
                EndingDate=x.EndingDate,
                Medicaments=x.Medicaments,
                Note = x.Note
            }).ToList();

            return PartialView("_Show", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
        {
            TherapiesMR.Details x = new TherapiesMR.Details();
            x.MedicalRecordId = Id;
            return PartialView("_Add", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(TherapiesMR.Details input)
        {

            Therapies x = new Therapies();
            x.BeginningDate = input.BeginningDate;
            x.EndingDate = input.EndingDate;
            x.Medicaments = input.Medicaments;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;
            _db.Therapies.Add(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            TherapiesMR.Details x = new TherapiesMR.Details();
            Therapies y = _db.Therapies.Where(i => i.TherapiesId == Id).SingleOrDefault();

            x.Id = y.TherapiesId;
            x.MedicalRecordId = y.MedicalRecordId;

            x.BeginningDate = y.BeginningDate;
            x.EndingDate = y.EndingDate;
            x.Medicaments = y.Medicaments;
            x.Note = y.Note;

            return PartialView("_Edit", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(TherapiesMR.Details input)
        {
            Therapies x = _db.Therapies.Where(i => i.TherapiesId == input.Id).SingleOrDefault();
            x.BeginningDate = input.BeginningDate;
            x.EndingDate = input.EndingDate;
            x.Medicaments = input.Medicaments;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;

            _db.Therapies.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
        {
            Therapies x = _db.Therapies.Where(i => i.TherapiesId == Id).SingleOrDefault();
            _db.Therapies.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}