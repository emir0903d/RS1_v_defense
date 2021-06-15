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
    [Authorize(Roles = "Patient, Doctor, Nurse")]
    [AutoValidateAntiforgeryToken]
    public class PregnanciesPreviousController : Controller
    {
        private Context _db { get; }
        public PregnanciesPreviousController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            PregnanciesPreviousMR x = new PregnanciesPreviousMR();
            x.MedicalRecordId = Id;
            x.Pregnancies = _db.PreviousPregnancyHistory.Where(a => a.MedicalRecordId == Id).Select(x => new PregnanciesPreviousMR.Details
            {
                Id = x.PreviousPregnancyHistoryId,
                PregnancyDate = x.PregnancyDate,
                GestationWeeks=x.GestationWeeks,
                DeliveryType = x.DeliveryType,
                Complications=x.Complications,
                Outcome=x.Outcome
            }).ToList();

            return PartialView("_Show", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
        {
            PregnanciesPreviousMR.Details x = new PregnanciesPreviousMR.Details();
            x.MedicalRecordId = Id;
            x.Outcomes= new List<SelectListItem>{
                new SelectListItem() { Value="Baby Boy", Text="Baby Boy"},
                new SelectListItem() { Value = "Baby Girl", Text = "Baby Girl" }
            };
            return PartialView("_Add", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(PregnanciesPreviousMR.Details input)
        {

            PreviousPregnancyHistory x = new PreviousPregnancyHistory();
            x.PregnancyDate = input.PregnancyDate;
            x.GestationWeeks = input.GestationWeeks;
            x.DeliveryType = input.DeliveryType;
            x.Complications = input.Complications;
            x.Outcome = input.Outcome;
            x.MedicalRecordId = input.MedicalRecordId;
            _db.PreviousPregnancyHistory.Add(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            PregnanciesPreviousMR.Details x = new PregnanciesPreviousMR.Details();
            PreviousPregnancyHistory y = _db.PreviousPregnancyHistory.Where(i => i.PreviousPregnancyHistoryId == Id).SingleOrDefault();

            x.Id = y.PreviousPregnancyHistoryId;
            x.MedicalRecordId = y.MedicalRecordId;
            x.PregnancyDate = y.PregnancyDate;
            x.GestationWeeks = y.GestationWeeks;
            x.DeliveryType = y.DeliveryType;
            x.Complications = y.Complications;
            x.Outcome = y.Outcome;
            x.Outcomes = new List<SelectListItem>{
                new SelectListItem() { Value="Baby Boy", Text="Baby Boy"},
                new SelectListItem() { Value = "Baby Girl", Text = "Baby Girl" }
            };
            return PartialView("_Edit", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(PregnanciesPreviousMR.Details input)
        {
            PreviousPregnancyHistory x = _db.PreviousPregnancyHistory.Where(i => i.PreviousPregnancyHistoryId == input.Id).SingleOrDefault();
            x.PreviousPregnancyHistoryId = input.Id;
            x.PregnancyDate = input.PregnancyDate;
            x.GestationWeeks = input.GestationWeeks;
            x.DeliveryType = input.DeliveryType;
            x.Outcome = input.Outcome;
            x.Complications = input.Complications;
            x.MedicalRecordId = input.MedicalRecordId;

            _db.PreviousPregnancyHistory.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
        {
            PreviousPregnancyHistory x = _db.PreviousPregnancyHistory.Where(i => i.PreviousPregnancyHistoryId == Id).SingleOrDefault();
            _db.PreviousPregnancyHistory.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}