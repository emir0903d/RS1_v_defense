using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Records.Models
{
    public class PregnanciesPreviousMR
    {
        public int MedicalRecordId { get; set; }
        public List<Details> Pregnancies { get; set; }

        public class Details
        {
            public int Id { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime PregnancyDate { get; set; }

            public int GestationWeeks { get; set; }

            [MaxLength(30, ErrorMessage = "MaxLength is 30 charachters!")]
            public string DeliveryType { get; set; }

            [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
            public string Complications { get; set; }

            [MaxLength(50, ErrorMessage = "MaxLength is 50 charachters!")]
            public string Outcome { get; set; }
            public List<SelectListItem> Outcomes { get; set; }

            public int MedicalRecordId { get; set; }
        }
    }
}
