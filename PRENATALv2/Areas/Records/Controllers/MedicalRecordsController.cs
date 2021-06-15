using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PRENATALv2.Areas.Home.Data;
using PRENATALv2.Areas.Home.Models;
using PRENATALv2.Areas.Records.Models;

namespace PRENATALv2.Areas.Records.Controllers
{
    [Area("Records")]
    [Authorize(Roles = "Patient, Doctor, Nurse")]
    [AutoValidateAntiforgeryToken]
    public class MedicalRecordsController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private Context _db { get; }
        public MedicalRecordsController(Context context, UserManager<AppUser> UserManager)
        {
            UserMgr = UserManager;
            _db = context;
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult ShowAll()
        {
           return View("ShowAll");
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public JsonResult JsonShowAll()
        {
            var List = _db.MedicalRecord.Select(x => new MR
            {
                Id = x.MedicalRecordId,
                MedicalRecordNumber = x.MedicalRecordNumber,
                PersonalIdentificationNumber = x.PersonalIdentificationNumber,
                Name = UserMgr.Users.Where(a => a.Id == x.MedicalRecordId).SingleOrDefault().Name,
                Surname = UserMgr.Users.Where(a => a.Id == x.MedicalRecordId).SingleOrDefault().Surname,
                BloodType = x.BloodType,
                RhFactor = x.RHFactor,

                BirthDate = x.BirthDate,
                
                PhoneNumber = UserMgr.Users.Where(a => a.Id == x.MedicalRecordId).SingleOrDefault().PhoneNumber,
                Email = UserMgr.Users.Where(a => a.Id == x.MedicalRecordId).SingleOrDefault().Email
                
                

            }).ToList();

            return Json(data: new { data = List });
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult AddOne(int Id)
        {
            MR x = new MR();
            x.MedicalRecordNumber = "MRN000" + Id.ToString();
            x.Id = Id;
            x.PhoneNumber = UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().PhoneNumber;
            x.Email = UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().Email;
            x.DoctorId= UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().DoctorId;
            x.DoctorObj = UserMgr.Users.Where(a => a.Id == x.DoctorId).SingleOrDefault();
            x.Doctor = UserMgr.Users.Where(a => a.Id == x.DoctorId).SingleOrDefault().Name + " " +
                UserMgr.Users.Where(a => a.Id == x.DoctorId).SingleOrDefault().Surname;
            x.Name = UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().Name;
            x.Surname = UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().Surname;
            x.StatusList = new List<SelectListItem>()
            {
                new SelectListItem(){Value="Single",Text="Single"},
                new SelectListItem(){Value="Married",Text="Married"},
                new SelectListItem(){Value="Divorced",Text="Divorced"},
                new SelectListItem(){Value="Widowed",Text="Widowed"},
            };
            x.BloodTypes = new List<SelectListItem>()
            {
                new SelectListItem(){Value="A",Text="A"},
                new SelectListItem(){Value="B",Text="B"},
                new SelectListItem(){Value="AB",Text="AB"},
                new SelectListItem(){Value="0",Text="0"},
            };
            x.RhFactors = new List<SelectListItem>()
            {
                new SelectListItem(){Value="+",Text="+"},
                new SelectListItem(){Value="-",Text="-"}
               
            };
            return View("AddOne",x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveNew(MR input)
        {
            MedicalRecord x = new MedicalRecord();
            x.MartialStatus = input.MartialStatus;
            x.PersonalIdentificationNumber = input.PersonalIdentificationNumber;
            x.MaidenName = input.MaidenName;
            x.BirthDate = input.BirthDate;
            x.MedicalRecordId = input.Id;
            x.MedicalRecordNumber = input.MedicalRecordNumber;
            x.BloodType = input.BloodType;
            x.RHFactor = input.RhFactor;
                        
            _db.MedicalRecord.Add(x);
            _db.SaveChanges();
            _db.Dispose();

            return Redirect("ShowOne?Id="+x.MedicalRecordId);
        }

        [Authorize(Roles = "Patient, Doctor, Nurse")]
        public IActionResult ShowOne(int Id)
        {
            if(_db.MedicalRecord.Where(a => a.MedicalRecordId == Id).SingleOrDefault() == null)
            {
                return Redirect("/Home/Account/AccessDenied");
            }
            MR x = new MR();
           
            x.Id=_db.MedicalRecord.Where(a => a.MedicalRecordId == Id).SingleOrDefault().MedicalRecordId;
            x.PersonalIdentificationNumber = _db.MedicalRecord.Where(a => a.MedicalRecordId == Id).SingleOrDefault().PersonalIdentificationNumber;
            x.Name = UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().Name;
            x.Surname = UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().Surname;
            x.PhoneNumber= UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().PhoneNumber;
            x.Email= UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().Email;
            x.DoctorId= UserMgr.Users.Where(a => a.Id == Id).SingleOrDefault().DoctorId;
            x.DoctorObj = UserMgr.Users.Where(a => a.Id == x.DoctorId).SingleOrDefault();
            x.Doctor = UserMgr.Users.Where(a => a.Id == x.DoctorId).SingleOrDefault().Name + " " +
                UserMgr.Users.Where(a => a.Id == x.DoctorId).SingleOrDefault().Surname;
            x.MartialStatus = _db.MedicalRecord.Where(a => a.MedicalRecordId == Id).SingleOrDefault().MartialStatus;
            x.MaidenName= _db.MedicalRecord.Where(a => a.MedicalRecordId == Id).SingleOrDefault().MaidenName;
            x.BirthDate= _db.MedicalRecord.Where(a => a.MedicalRecordId == Id).SingleOrDefault().BirthDate;
            x.MedicalRecordNumber= _db.MedicalRecord.Where(a => a.MedicalRecordId == Id).SingleOrDefault().MedicalRecordNumber;
            x.BloodType= _db.MedicalRecord.Where(a => a.MedicalRecordId == Id).SingleOrDefault().BloodType;
            x.RhFactor= _db.MedicalRecord.Where(a => a.MedicalRecordId == Id).SingleOrDefault().RHFactor;
            
            return View("ShowOne",x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add()
        {
            MR_newPatients x = new MR_newPatients();
            x.NewP_List = UserMgr.Users.Include(r => r.MedicalRecord)
                .Where(mr => mr.MedicalRecord == null)
                .Where(t=>t.Type==AppUser.UserType.Patient)
                .Where(s => s.Status == AppUser.UserStatus.Approved).Select(x => new SelectListItem
                {
                    Value=x.Id.ToString(),
                    Text=x.Name+" "+x.Surname
                }).ToList();
            x.NewP_Details = new List<MR_newPatients.PatientDetails>();
            foreach (SelectListItem p in x.NewP_List)
            {
                MR_newPatients.PatientDetails obj = new MR_newPatients.PatientDetails();
                obj.Id = UserMgr.Users.Where(u => u.Id.ToString() == p.Value).SingleOrDefault().Id;
                obj.Name = UserMgr.Users.Where(u => u.Id.ToString() == p.Value).SingleOrDefault().Name;
                obj.Surname = UserMgr.Users.Where(u => u.Id.ToString() == p.Value).SingleOrDefault().Surname;
                obj.PhoneNumber = UserMgr.Users.Where(u => u.Id.ToString() == p.Value).SingleOrDefault().PhoneNumber;
                obj.Email = UserMgr.Users.Where(u => u.Id.ToString() == p.Value).SingleOrDefault().Email;
                obj.DoctorId = UserMgr.Users.Where(u => u.Id.ToString() == p.Value).SingleOrDefault().DoctorId;
                obj.Doctor = UserMgr.Users.Where(u => u.Id == obj.DoctorId).SingleOrDefault().Name +" "+
                    UserMgr.Users.Where(u => u.Id == obj.DoctorId).SingleOrDefault().Surname;
 
                x.NewP_Details.Add(obj);
            }
            x.StatusList = new List<SelectListItem>()
                {
                new SelectListItem(){Value="Single",Text="Single"},
                new SelectListItem(){Value="Married",Text="Married"},
                new SelectListItem(){Value="Divorced",Text="Divorced"},
                new SelectListItem(){Value="Widowed",Text="Widowed"},
                };
            x.BloodTypes = new List<SelectListItem>()
                {
                new SelectListItem(){Value="A",Text="A"},
                new SelectListItem(){Value="B",Text="B"},
                new SelectListItem(){Value="AB",Text="AB"},
                new SelectListItem(){Value="0",Text="0"},
                };
            x.RhFactors = new List<SelectListItem>()
                {
                new SelectListItem(){Value="+",Text="+"},
                new SelectListItem(){Value="-",Text="-"}

                };

            return View("Add",x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(MR_newPatients input)
        {
            MedicalRecord x = new MedicalRecord();

            x.MedicalRecordId = input.ChoosenPatientId;
            x.MedicalRecordNumber = "MRN000" + input.ChoosenPatientId;
            x.PersonalIdentificationNumber = input.PersonalIdentificationNumber;
            x.MaidenName = input.MaidenName;
            x.MartialStatus = input.MartialStatus;
            x.BirthDate = input.BirthDate;
            x.BloodType = input.BloodType;
            x.RHFactor = input.RhFactor;

            _db.MedicalRecord.Add(x);
            _db.SaveChanges();
            _db.Dispose();

            return RedirectToAction("ShowAll", "MedicalRecords");
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            MR x = new MR();
            x.Id = Id;
            x.DoctorId= UserMgr.Users.Where(i => i.Id == Id).SingleOrDefault().DoctorId;
            
            x.DoctorObj= UserMgr.Users.Where(i => i.Id == x.DoctorId).SingleOrDefault();
            x.Doctor = UserMgr.Users.Where(a => a.Id == x.DoctorId).SingleOrDefault().Name + " " +
                UserMgr.Users.Where(a => a.Id == x.DoctorId).SingleOrDefault().Surname;
            x.Name = UserMgr.Users.Where(i => i.Id == Id).SingleOrDefault().Name;
            x.Surname=UserMgr.Users.Where(i => i.Id == Id).SingleOrDefault().Surname;
            x.PhoneNumber= UserMgr.Users.Where(i => i.Id == Id).SingleOrDefault().PhoneNumber;
            x.Email = UserMgr.Users.Where(i => i.Id == Id).SingleOrDefault().Email;

            x.BirthDate = _db.MedicalRecord.Where(i => i.MedicalRecordId == Id).SingleOrDefault().BirthDate;
            x.MaidenName = _db.MedicalRecord.Where(i => i.MedicalRecordId == Id).SingleOrDefault().MaidenName;
            x.MartialStatus = _db.MedicalRecord.Where(i => i.MedicalRecordId == Id).SingleOrDefault().MartialStatus;
            x.PersonalIdentificationNumber = _db.MedicalRecord.Where(i => i.MedicalRecordId == Id).SingleOrDefault().PersonalIdentificationNumber;
            x.MedicalRecordNumber = _db.MedicalRecord.Where(i => i.MedicalRecordId == Id).SingleOrDefault().MedicalRecordNumber;
            x.BloodType= _db.MedicalRecord.Where(i => i.MedicalRecordId == Id).SingleOrDefault().BloodType;
            x.RhFactor = _db.MedicalRecord.Where(i => i.MedicalRecordId == Id).SingleOrDefault().RHFactor;
            
            x.StatusList = new List<SelectListItem>()
                {
                new SelectListItem(){Value="Single",Text="Single"},
                new SelectListItem(){Value="Married",Text="Married"},
                new SelectListItem(){Value="Divorced",Text="Divorced"},
                new SelectListItem(){Value="Widowed",Text="Widowed"},
                };
            x.BloodTypes = new List<SelectListItem>()
                {
                new SelectListItem(){Value="A",Text="A"},
                new SelectListItem(){Value="B",Text="B"},
                new SelectListItem(){Value="AB",Text="AB"},
                new SelectListItem(){Value="0",Text="0"},
                };
            x.RhFactors = new List<SelectListItem>()
                {
                new SelectListItem(){Value="+",Text="+"},
                new SelectListItem(){Value="-",Text="-"}

                };

            return View("Edit",x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(MR input)
        {
            MedicalRecord x = _db.MedicalRecord.Where(i => i.MedicalRecordId == input.Id).SingleOrDefault();
            x.PersonalIdentificationNumber = input.PersonalIdentificationNumber;
            x.RHFactor = input.RhFactor;
            x.BloodType = input.BloodType;
            x.MartialStatus = input.MartialStatus;
            x.MaidenName = input.MaidenName;
            x.BirthDate = input.BirthDate;
            _db.MedicalRecord.Update(x);
            _db.SaveChanges();
            _db.Dispose();

            return RedirectToAction("ShowAll", "MedicalRecords");
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public async Task<IActionResult> Delete(int Id)
        {
            AppUser u = await UserMgr.FindByIdAsync(Id.ToString());
            u.MedicalRecord = null;
            await UserMgr.UpdateAsync(u);

            MedicalRecord x = _db.MedicalRecord.Find(Id);
            _db.MedicalRecord.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return RedirectToAction("ShowAll", "MedicalRecords");
        }
    }
}