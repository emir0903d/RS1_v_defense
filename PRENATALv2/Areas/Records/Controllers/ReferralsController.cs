using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Google.Apis.Util;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PRENATALv2.Areas.Home.Data;
using PRENATALv2.Areas.Home.Models;
using PRENATALv2.Areas.Records.Models;

namespace PRENATALv2.Areas.Records.Controllers
{
    [Area("Records")]
    [Authorize(Roles = "Patient, Doctor, Nurse")]
    [AutoValidateAntiforgeryToken]
    public class ReferralsController : Controller
    {
        private Context _db { get; }
        public ReferralsController(Context context)
        {
            _db = context;
        }
        public IActionResult Show(int Id)
        {
            ReferralsMR x = new ReferralsMR();
            x.MedicalRecordId = Id;
            x.Referrals = _db.Referrals.Where(i => i.MedicalRecordId == Id).Select(r => new ReferralsMR.Details
            {
                Id = r.ReferralsId,
                Date = r.Date,
                Note = r.Note,
                BloodExams = _db.BloodExaminations.Where(ri => ri.ReferralsId == r.ReferralsId).Select(b => new BloodExamsRef {
                    Id=b.BloodExaminationsId,
                    BloodTest = b.BloodTest,
                    Unit=b.Unit,
                    Low=b.Low,
                    High=b.High,
                    Results=b.Results,
                    Date=b.Date
                }).ToList(),
                UrineExams = _db.UrineExaminations.Where(ui => ui.ReferralsId == r.ReferralsId).Select(u => new UrineExamsRef
                {
                    Id=u.UrineExaminationsId,
                    UrineTest = u.UrineTest,
                    ReferenceInterval=u.ReferenceInterval,
                    Unit=u.Unit,
                    Results=u.Results,
                    Date=u.Date
                }).ToList()
               

            }).ToList();

            return PartialView("_Show",x);
        }

        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Add(int Id)
        {
            ReferralsMR.Details x = new ReferralsMR.Details();
            x.MedicalRecordId = Id;
            x.BloodExams = new List<BloodExamsRef>
                {
                    new BloodExamsRef(){BloodTest="Blood01T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood02T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood03T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood04T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood05T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood06T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood07T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood08T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood09T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood010T",Unit="m/L",Low=1.2,High=4.9}
                };
            x.UrineExams = new List<UrineExamsRef>
                {
                    new UrineExamsRef(){UrineTest="Urine01T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine02T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine03T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine04T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine05T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine06T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine07T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine08T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine09T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine010T",ReferenceInterval="Od do",Unit="mol/dL"}
                };
            x.UrineExamsSelected = new List<string>();
            x.BloodExamsSelected = new List<string>();
            return PartialView("_Add", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Save(ReferralsMR.Details input)
        {

            Referrals x = new Referrals();
            x.Date = input.Date;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;
            _db.Referrals.Add(x);
            _db.SaveChanges();
            
            int RefId = x.ReferralsId;

            if (input.BloodExamsSelected.Count() > 0)
            {
                int s = 0;
                while (s < input.BloodExamsSelected.Count())
                {
                    for (int i = 0; i < input.BloodExams.Count(); i++)
                    {
                        if (input.BloodExamsSelected[s] == input.BloodExams[i].BloodTest)
                        {
                            BloodExaminations blood = new BloodExaminations();
                            blood.Unit = input.BloodExams[i].Unit;
                            blood.Low = input.BloodExams[i].Low;
                            blood.High = input.BloodExams[i].High;
                            blood.BloodTest = input.BloodExams[i].BloodTest;
                            blood.ReferralsId = RefId;
                            _db.BloodExaminations.Add(blood);
                            _db.SaveChanges();
                        }
                    }
                    s++;

                }
   
            }
            if (input.UrineExamsSelected.Count() > 0)
            {
                int s = 0;
                while (s < input.UrineExamsSelected.Count())
                {
                    for (int i = 0; i < input.UrineExams.Count(); i++)
                    {
                        if (input.UrineExamsSelected[s] == input.UrineExams[i].UrineTest)
                        {
                            UrineExaminations urine = new UrineExaminations();
                            urine.Unit = input.UrineExams[i].Unit;
                            urine.UrineTest = input.UrineExams[i].UrineTest;
                            urine.ReferenceInterval = input.UrineExams[i].ReferenceInterval;
                            urine.ReferralsId = RefId;
                            _db.UrineExaminations.Add(urine);
                            _db.SaveChanges();
                        }
                    }
                    s++;

                }

            }


            _db.SaveChanges();
            _db.Dispose();

            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Edit(int Id)
        {
            ReferralsMR.Details x = new ReferralsMR.Details();
            x = _db.Referrals.Where(r => r.ReferralsId == Id).Select(y => new ReferralsMR.Details
            {
                Id = y.ReferralsId,
                Date = y.Date,
                Note = y.Note,
                MedicalRecordId = y.MedicalRecordId,
                BloodExamsSelected = new List<string>(),
                UrineExamsSelected=new List<string>()
                
            }).SingleOrDefault();
            x.BloodExams = new List<BloodExamsRef>
                {
                    new BloodExamsRef(){BloodTest="Blood01T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood02T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood03T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood04T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood05T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood06T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood07T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood08T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood09T",Unit="m/L",Low=1.2,High=4.9},
                    new BloodExamsRef(){BloodTest="Blood010T",Unit="m/L",Low=1.2,High=4.9}
                };
            x.UrineExams = new List<UrineExamsRef>
                {
                    new UrineExamsRef(){UrineTest="Urine01T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine02T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine03T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine04T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine05T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine06T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine07T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine08T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine09T",ReferenceInterval="Od do",Unit="mol/dL"},
                    new UrineExamsRef(){UrineTest="Urine010T",ReferenceInterval="Od do",Unit="mol/dL"}
                };
           
            x._dbBloodExams = _db.BloodExaminations.Where(ui => ui.ReferralsId == x.Id).Select(z=>new SelectListItem
            {
                Value=z.BloodTest,
                Text=z.BloodTest,
                Selected=true,
                Group=null,
                Disabled=false
            }).ToList();
            x.BloodExamsSelected= _db.BloodExaminations.Where(bi => bi.ReferralsId == x.Id).Select(n => n.BloodTest).ToList();

            x._dbUrineExams = _db.UrineExaminations.Where(ui => ui.ReferralsId == x.Id).Select(z => new SelectListItem
            {
                Value=z.UrineTest,
                Text=z.UrineTest,
                Selected=true,
                Group=null,
                Disabled=false
               
            }).ToList();
            x.UrineExamsSelected = _db.UrineExaminations.Where(ui => ui.ReferralsId == x.Id).Select(n => n.UrineTest).ToList();
            return PartialView("_Edit", x);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult SaveExisting(ReferralsMR.Details input)
        {
            Referrals x = _db.Referrals.Where(i => i.ReferralsId == input.Id).SingleOrDefault();
            x.Date = input.Date;
            x.Note = input.Note;
            x.MedicalRecordId = input.MedicalRecordId;
            _db.Referrals.Update(x);
            _db.SaveChanges();

            int RefId = x.ReferralsId;
            
            if (input.BloodExamsSelected.Count() > 0)
            {
                int s = 0;
                
                while (s < input.BloodExamsSelected.Count())
                {

                    List<BloodExaminations> check_list = _db.BloodExaminations.Where(i => i.ReferralsId == RefId).ToList();
                    for(int j=0; j<check_list.Count(); j++)
                    {
                        if (input.BloodExamsSelected[s] != check_list[j].BloodTest)
                        {
                            _db.BloodExaminations.Remove(check_list[j]);
                            _db.SaveChanges();
                        }
                    }
                    s++;

                }
                s = 0;
                while (s < input.BloodExamsSelected.Count())
                {
                    for (int i = 0; i < input.BloodExams.Count(); i++)
                    {
                        if (input.BloodExamsSelected[s] == input.BloodExams[i].BloodTest && !_db.BloodExaminations.Where(n=>n.BloodTest==input.BloodExamsSelected[s]).Any())
                        {
                            BloodExaminations blood = new BloodExaminations();
                            blood.Unit = input.BloodExams[i].Unit;
                            blood.Low = input.BloodExams[i].Low;
                            blood.High = input.BloodExams[i].High;
                            blood.BloodTest = input.BloodExams[i].BloodTest;
                            blood.ReferralsId = RefId;
                            _db.BloodExaminations.Add(blood);
                            _db.SaveChanges();
                        }
                      

                    }
                    s++;
                }
            }

            if (input.UrineExamsSelected.Count() > 0)
            {
                int s = 0;

                while (s < input.UrineExamsSelected.Count())
                {

                    List<UrineExaminations> check_list = _db.UrineExaminations.Where(i => i.ReferralsId == RefId).ToList();
                    for (int j = 0; j < check_list.Count(); j++)
                    {
                        if (input.UrineExamsSelected[s] != check_list[j].UrineTest)
                        {
                            _db.UrineExaminations.Remove(check_list[j]);
                            _db.SaveChanges();
                        }
                    }
                    s++;

                }
                s = 0;
                while (s < input.UrineExamsSelected.Count())
                {
                    for (int i = 0; i < input.UrineExams.Count(); i++)
                    {
                        if (input.UrineExamsSelected[s] == input.UrineExams[i].UrineTest && !_db.UrineExaminations.Where(n => n.UrineTest == input.UrineExamsSelected[s]).Any())
                        {
                            UrineExaminations urine = new UrineExaminations();
                            urine.Unit = input.UrineExams[i].Unit;
                            urine.UrineTest = input.UrineExams[i].UrineTest;
                            urine.ReferenceInterval = input.UrineExams[i].ReferenceInterval;
                            urine.ReferralsId = RefId;
                            _db.UrineExaminations.Add(urine);
                            _db.SaveChanges();
                        }


                    }
                    s++;
                }
            }


            _db.Dispose();

            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + input.MedicalRecordId);
        }
        [Authorize(Roles = "Doctor, Nurse")]
        public IActionResult Delete(int Id)
        {
            Referrals x = _db.Referrals.Where(i => i.ReferralsId == Id).SingleOrDefault();
            _db.Referrals.Remove(x);
            _db.SaveChanges();
            _db.Dispose();
            return Redirect("/Records/MedicalRecords/ShowOne?Id=" + x.MedicalRecordId);
        }
    }
}