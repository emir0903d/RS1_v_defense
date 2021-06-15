using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PRENATALv2.Areas.Home.Data;
using PRENATALv2.Areas.Home.Models;
using PRENATALv2.Areas.Records.Models;

namespace PRENATALv2.Areas.Records.Controllers
{
    [Area("Records")]
    [Authorize (Roles = "Patient, Doctor, Nurse")]
    [AutoValidateAntiforgeryToken]
    public class FilesController : Controller
    {
        private Context _db { get; }
        private IHostingEnvironment hostingEnv;
        public FilesController(Context context, IHostingEnvironment hostingEnvironment)
        {
            _db = context;
            hostingEnv = hostingEnvironment;
        }
        public IActionResult Show(int Id)
        {
            FilesMR x = new FilesMR();
            x.MedicalRecordId = Id;
            x.Files = _db.Files.Where(i => i.MedicalRecordId == Id).Select(y => new FilesMR.Details
            {
                Id=y.FileId,
                Name=y.Name,
                Date=y.Date,
                Data=y.Data,
                Type=y.Type

            }).ToList();
            return PartialView("_Show", x);
        }
        public IActionResult Add(int Id)
        {
            FilesMR x = new FilesMR();
            x.MedicalRecordId = Id;
            return PartialView("_Add", x);
        }
        public IActionResult Save(FilesMR input, IList<IFormFile> files)
        {
            if (Request.Form.Files != null)
            {
                if (Request.Form.Files.Count() > 0)
                {
                    foreach(IFormFile x in Request.Form.Files)
                    {
                        var fileName = Path.GetFileName(x.FileName);
                        var fileExtension = Path.GetExtension(x.FileName);
                        //var newFileName = String.Concat(Convert.ToString(Guid.NewGuid()), fileExtension);
                        //var newFileName = String.Concat(fileName, fileExtension);
                        var objfiles = new Files()
                        {
                            MedicalRecordId=input.MedicalRecordId,
                            Name = fileName,//newFileName
                            Type = fileExtension,
                            Date = DateTime.Now
                        };
                        using (var target = new MemoryStream())
                        {
                            x.CopyTo(target);
                            objfiles.Data = target.ToArray();
                        }

                        _db.Files.Add(objfiles);
                        _db.SaveChanges();
                    }
                    
                }
            }
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        public IActionResult GetFile(int Id)
        {
            Files x = _db.Files.Where(i => i.FileId == Id).SingleOrDefault();

            if (x.Type == ".pdf")
            {                         
                //byte[] pdfBytes = Encoding.ASCII.GetBytes(x.Data.ToString());
                MemoryStream ms = new MemoryStream(x.Data);
                return File(ms, System.Net.Mime.MediaTypeNames.Application.Octet, x.Name);
            }    
            
             return File(x.Data, "application/txt", x.Name);
        }
        public IActionResult Delete(int Id)
        {
            Files x = _db.Files.Find(Id);
            _db.Files.Remove(x);
            _db.SaveChanges();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}