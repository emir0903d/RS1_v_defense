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
    public class UltrasoundsController : Controller
    {
        private Context _db { get; }
        public UltrasoundsController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            UltrasoundsMR x = new UltrasoundsMR();
            x.MedicalRecordId = Id;
            x.Ultrasounds = _db.Ultrasound.Where(a => a.MedicalRecordId == Id).Select(x => new UltrasoundsMR.Details
            {
                Id = x.UltrasoundId,
                Date=x.Date,
                HeartBeats=x.HeartBeats,
                Movement=x.Movement,
                Length=x.Length,
                NuchalScan=x.NuchalScan,
                Anomalies=x.Anomalies,
                HeadDiameter=x.HeadDiameter,
                HeadCircumference=x.HeadCircumference,
                AbdominalCircumference=x.AbdominalCircumference,
                FemurLength=x.FemurLength,
                Note = x.Note
            }).ToList();

            return PartialView("_Show", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
        {
            UltrasoundsMR.Details x = new UltrasoundsMR.Details();
            x.MedicalRecordId = Id;
            return PartialView("_Add", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(UltrasoundsMR.Details input)
        {

            Ultrasound x = new Ultrasound();

            x.Date = input.Date;
            x.HeartBeats = input.HeartBeats;
            x.Movement = input.Movement;
            x.Length = input.Length;
            x.NuchalScan = input.NuchalScan;
            x.Anomalies = input.Anomalies;
            x.HeadDiameter = input.HeadDiameter;
            x.HeadCircumference = input.HeadCircumference;
            x.AbdominalCircumference = input.AbdominalCircumference;
            x.FemurLength = input.FemurLength;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;
            _db.Ultrasound.Add(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            UltrasoundsMR.Details x = new UltrasoundsMR.Details();
            Ultrasound y = _db.Ultrasound.Where(i => i.UltrasoundId == Id).SingleOrDefault();
            x.Id = y.UltrasoundId;
            x.Date = y.Date;
            x.HeartBeats = y.HeartBeats;
            x.Movement = y.Movement;
            x.Length = y.Length;
            x.NuchalScan = y.NuchalScan;
            x.Anomalies = y.Anomalies;
            x.HeadDiameter = y.HeadDiameter;
            x.HeadCircumference = y.HeadCircumference;
            x.AbdominalCircumference = y.AbdominalCircumference;
            x.FemurLength = y.FemurLength;
            x.Note = y.Note;
            x.MedicalRecordId = y.MedicalRecordId;

            return PartialView("_Edit", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(UltrasoundsMR.Details input)
        {
            Ultrasound x = _db.Ultrasound.Where(i => i.UltrasoundId == input.Id).SingleOrDefault();
            x.UltrasoundId = input.Id;
            x.Date = input.Date;
            x.HeartBeats = input.HeartBeats;
            x.Movement = input.Movement;
            x.Length = input.Length;
            x.NuchalScan = input.NuchalScan;
            x.Anomalies = input.Anomalies;
            x.HeadDiameter = input.HeadDiameter;
            x.HeadCircumference = input.HeadCircumference;
            x.AbdominalCircumference = input.AbdominalCircumference;
            x.FemurLength = input.FemurLength;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;

            _db.Ultrasound.Update(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
        {
            Ultrasound x = _db.Ultrasound.Where(i => i.UltrasoundId == Id).SingleOrDefault();
            _db.Ultrasound.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}