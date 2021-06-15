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
    public class MedicalHistoriesController : Controller
    {
        private Context _db { get; }
        public MedicalHistoriesController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            MedicalHistoriesMR x = new MedicalHistoriesMR();
            x.MedicalRecordId = Id;
            x.MedicalHistories = _db.MedicalHistory.Where(a => a.MedicalRecordId == Id).Select(x => new MedicalHistoriesMR.Details
            {
                Id = x.MedicalHistoryId,
                Date = x.Date,
                Diagnosis = x.Diagnosis,
                Note=x.Note
            }).ToList();

            return PartialView("_Show", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
        {
            MedicalHistoriesMR.Details x = new MedicalHistoriesMR.Details();
            x.MedicalRecordId = Id;
            return PartialView("_Add", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(MedicalHistoriesMR.Details input)
        {

            MedicalHistory x = new MedicalHistory();
            x.Date= input.Date;
            x.Diagnosis = input.Diagnosis;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;
            _db.MedicalHistory.Add(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            MedicalHistoriesMR.Details x = new MedicalHistoriesMR.Details();
            MedicalHistory y = _db.MedicalHistory.Where(i => i.MedicalHistoryId == Id).SingleOrDefault();

            x.Id = y.MedicalHistoryId;
            x.MedicalRecordId = y.MedicalRecordId;
            x.Date = y.Date;
            x.Diagnosis = y.Diagnosis;
            x.Note = y.Note;
            return PartialView("_Edit", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(MedicalHistoriesMR.Details input)
        {
            MedicalHistory x = _db.MedicalHistory.Where(i => i.MedicalHistoryId == input.Id).SingleOrDefault();
            x.Date = input.Date;
            x.Diagnosis = input.Diagnosis;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;

            _db.MedicalHistory.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
        {
            MedicalHistory x = _db.MedicalHistory.Where(i => i.MedicalHistoryId == Id).SingleOrDefault();
            _db.MedicalHistory.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}