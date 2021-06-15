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
    public class VitalSignsController : Controller
        {
            private Context _db { get; }
            public VitalSignsController(Context context)
            {
                _db = context;
            }
        [Authorize(Roles = "Patient, Doctor, Nurse")]
        public IActionResult Show(int Id)
            {
                VitalSignsMR x = new VitalSignsMR();
                x.MedicalRecordId = Id;
                x.VitalSigns = _db.VitalSigns.Where(a => a.MedicalRecordId == Id).Select(x => new VitalSignsMR.Details
                {
                    Id = x.VitalSignsId,
                    Date=x.Date,
                    Temperature=x.Temperature,
                    SystolicPressure=x.SystolicPressure,
                    DiastolicPressure=x.DiastolicPressure,
                    HeartBeats=x.HeartBeats,
                    RespiratoryRate=x.RespiratoryRate,
                    Height=x.Height,
                    Weight=x.Weight,
                    Note = x.Note
                }).ToList();

                return PartialView("_Show", x);
            }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
            {
            VitalSignsMR.Details x = new VitalSignsMR.Details();
                x.MedicalRecordId = Id;
                return PartialView("_Add", x);
            }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(VitalSignsMR.Details input)
            {

                VitalSigns x = new VitalSigns();
                x.Date = input.Date;
                x.Temperature = input.Temperature;
                x.SystolicPressure = input.SystolicPressure;
                x.DiastolicPressure = input.DiastolicPressure;
                x.HeartBeats = input.HeartBeats;
                x.RespiratoryRate = input.RespiratoryRate;
                x.Height = input.Height;
                x.Weight = input.Weight;
                x.Note = input.Note;
                x.MedicalRecordId = input.MedicalRecordId;
                _db.VitalSigns.Add(x);
                _db.SaveChanges();
                _db.Dispose();
                return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
            }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
            {
            VitalSignsMR.Details x = new VitalSignsMR.Details();
            VitalSigns y = _db.VitalSigns.Where(i => i.VitalSignsId == Id).SingleOrDefault();

            x.Id = y.VitalSignsId;
            x.Date = y.Date;
            x.Temperature = y.Temperature;
            x.SystolicPressure = y.SystolicPressure;
            x.DiastolicPressure = y.DiastolicPressure;
            x.HeartBeats = y.HeartBeats;
            x.RespiratoryRate = y.RespiratoryRate;
            x.Height = y.Height;
            x.Weight = y.Weight;
            x.Note = y.Note;
            x.MedicalRecordId = y.MedicalRecordId;

            return PartialView("_Edit", x);
            }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(VitalSignsMR.Details input)
            {
                VitalSigns x = _db.VitalSigns.Where(i => i.VitalSignsId == input.Id).SingleOrDefault();
            x.VitalSignsId = input.Id;
            x.Date = input.Date;
            x.Temperature = input.Temperature;
            x.SystolicPressure = input.SystolicPressure;
            x.DiastolicPressure = input.DiastolicPressure;
            x.HeartBeats = input.HeartBeats;
            x.RespiratoryRate = input.RespiratoryRate;
            x.Height = input.Height;
            x.Weight = input.Weight;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;

            _db.VitalSigns.Update(x);
                _db.SaveChanges();
                _db.Dispose();
                return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
            }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
            {
                VitalSigns x = _db.VitalSigns.Where(i => i.VitalSignsId == Id).SingleOrDefault();
                _db.VitalSigns.Remove(x);
                _db.SaveChanges();
                _db.Dispose();
                return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
            }
        }
    
}