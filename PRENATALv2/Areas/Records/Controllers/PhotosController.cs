using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PRENATALv2.Areas.Home.Data;
using PRENATALv2.Areas.Home.Models;
using PRENATALv2.Areas.Records.Models;
using System.Web;

namespace PRENATALv2.Areas.Records.Controllers
{
    [Area("Records")]
    [Authorize(Roles = "Patient, Doctor, Nurse")]
    [AutoValidateAntiforgeryToken]
    public class PhotosController : Controller
    {
        private Context _db { get; }
        public PhotosController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            PhotosMR x = new PhotosMR();
            x.MedicalRecordId = Id;
            x.Photos = _db.Photos.Where(i => i.MedicalRecordId == Id).Select(y => new PhotosMR.Details
            {
                Date = y.Date,
                Id = y.PhotoId,
                MedicalRecordId = y.MedicalRecordId,
                Title = y.Title,
                Data = y.Data
                
            }).ToList();
            foreach(PhotosMR.Details i in x.Photos)
            {
                i.Base64Data = Convert.ToBase64String(i.Data);
                i.DataURL = string.Format("data:image/jpg;base64,{0}", i.Base64Data);
            }
            return PartialView("_Show", x);
        }
        public IActionResult Add(int Id)
        {
            PhotosMR.Details x = new PhotosMR.Details();
            x.MedicalRecordId = Id;
            return PartialView("_Add",x);
        }
        public IActionResult Save(PhotosMR.Details input)
        {
            foreach (var file in Request.Form.Files)
            {
                Photos img = new Photos();
                img.Title = file.FileName;
                img.MedicalRecordId = input.MedicalRecordId;
                img.Date = DateTime.Now;

                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                img.Data = ms.ToArray();

                ms.Close();
                ms.Dispose();

                _db.Photos.Add(img);
                _db.SaveChanges();
            }
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);

        }
        public IActionResult Delete(int Id)
        {
            Photos x = _db.Photos.Find(Id);
            _db.Photos.Remove(x);
            _db.SaveChanges();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }

    }
}