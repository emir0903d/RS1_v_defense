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
    public class PregnanciesLossController : Controller
    {
        private Context _db { get; }
        public PregnanciesLossController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            PregnanciesLossMR x = new PregnanciesLossMR();
            x.MedicalRecordId = Id;
            x.Pregnancies = _db.PregnancyLossHistory.Where(a => a.MedicalRecordId == Id).Select(x => new PregnanciesLossMR.Details
            {
                Id = x.PregnancyLossHistoryId,
                PregnancyLossDate=x.PregnancyLossDate,
                Type = x.Type,
                Note = x.Note
            }).ToList();

            return PartialView("_Show", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
        {
            PregnanciesLossMR.Details x = new PregnanciesLossMR.Details();
            x.MedicalRecordId = Id;
            return PartialView("_Add", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(PregnanciesLossMR.Details input)
        {

            PregnancyLossHistory x = new PregnancyLossHistory();
            x.Type = input.Type;
            x.PregnancyLossDate = input.PregnancyLossDate;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;
            _db.PregnancyLossHistory.Add(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            PregnanciesLossMR.Details x = new PregnanciesLossMR.Details();
            PregnancyLossHistory y = _db.PregnancyLossHistory.Where(i => i.PregnancyLossHistoryId == Id).SingleOrDefault();

            x.Id = y.PregnancyLossHistoryId;
            x.MedicalRecordId = y.MedicalRecordId;
            x.Type = y.Type;
            x.PregnancyLossDate = y.PregnancyLossDate;
            x.Note = y.Note;

            return PartialView("_Edit", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(PregnanciesLossMR.Details input)
        {
            PregnancyLossHistory x = _db.PregnancyLossHistory.Where(i => i.PregnancyLossHistoryId == input.Id).SingleOrDefault();
            x.Type = input.Type;
            x.PregnancyLossDate = input.PregnancyLossDate;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;

            _db.PregnancyLossHistory.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
        {
            PregnancyLossHistory x = _db.PregnancyLossHistory.Where(i => i.PregnancyLossHistoryId == Id).SingleOrDefault();
            _db.PregnancyLossHistory.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}