using Microsoft.AspNetCore.Mvc.Rendering;
using PRENATALv2.Areas.Home.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Records.Models
{
    public class ReferralsMR
    {
        public int MedicalRecordId { get; set; }
        public List<Details> Referrals { get; set; }

        public class Details
        {
            public int Id { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime Date { get; set; }
            public string Note { get; set; }
            public int MedicalRecordId { get; set; }
            public List<string> BloodExamsSelected { get; set; }
            public List<BloodExamsRef> BloodExams { get; set; }
            public List<string> UrineExamsSelected { get; set; }
            public List<UrineExamsRef> UrineExams { get; set; }
            public List<SelectListItem> _dbBloodExams { get; set; }
            public List<SelectListItem> _dbUrineExams { get; set; }
        }
    }
}
