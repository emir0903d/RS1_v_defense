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
    public class SubstancesUseController : Controller
    {
        private Context _db { get; }
        public SubstancesUseController(Context context)
        {
            _db = context;
        }

        public IActionResult Show(int Id)
        {
            SubstancesUseMR x = new SubstancesUseMR();
            x.MedicalRecordId = Id;
            x.Substances = _db.HistoryOfSubstanceUse.Where(a => a.MedicalRecordId == Id).Select(x => new SubstancesUseMR.Details
            {
                Id = x.HistoryOfSubstanceUseId,
                Description=x.Description,
                PriorToPregnancy=x.PriorToPregnancy,
                NumberOfYears=x.NumberOfYears,
                StillUsing=x.StillUsing,
                Note = x.Note
            }).ToList();

            return PartialView("_Show", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
        {
            SubstancesUseMR.Details x = new SubstancesUseMR.Details();
            x.MedicalRecordId = Id;
            return PartialView("_Add", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(SubstancesUseMR.Details input)
        {

            HistoryOfSubstanceUse x = new HistoryOfSubstanceUse();
            x.Description = input.Description;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;
            x.NumberOfYears = input.NumberOfYears;
            x.PriorToPregnancy = input.PriorToPregnancy;
            x.StillUsing = input.StillUsing;
            
            _db.HistoryOfSubstanceUse.Add(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            SubstancesUseMR.Details x = new SubstancesUseMR.Details();
            HistoryOfSubstanceUse y = _db.HistoryOfSubstanceUse.Where(i => i.HistoryOfSubstanceUseId == Id).SingleOrDefault();

            x.Id = y.HistoryOfSubstanceUseId;
            x.MedicalRecordId = y.MedicalRecordId;
            x.Description = y.Description;
            x.Note = y.Note;
            x.NumberOfYears = y.NumberOfYears;
            x.PriorToPregnancy = y.PriorToPregnancy;
            x.StillUsing = y.StillUsing;
            

            return PartialView("_Edit", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(SubstancesUseMR.Details input)
        {
            HistoryOfSubstanceUse x = _db.HistoryOfSubstanceUse.Where(i => i.HistoryOfSubstanceUseId == input.Id).SingleOrDefault();
            x.Description = input.Description;
            x.Note = input.Note;
            x.NumberOfYears = input.NumberOfYears;
            x.PriorToPregnancy = input.PriorToPregnancy;
            x.StillUsing = input.StillUsing;
            x.MedicalRecordId = input.MedicalRecordId;

            _db.HistoryOfSubstanceUse.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
        {
            HistoryOfSubstanceUse x = _db.HistoryOfSubstanceUse.Where(i => i.HistoryOfSubstanceUseId == Id).SingleOrDefault();
            _db.HistoryOfSubstanceUse.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}