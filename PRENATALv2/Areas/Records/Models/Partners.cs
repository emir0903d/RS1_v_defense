using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Records.Models
{
    public class Partners
    {
        public int MedicalRecordId { get; set; }
        public List<Details> ListPartners { get; set; }

        public class Details
        {
            public int PartnerId { get; set; }

            [StringLength(15, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
            [Required(ErrorMessage = "This field is required!")]
            public string Name { get; set; }

            [StringLength(30, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
            [Required(ErrorMessage = "This field is required!")]
            public string Surname { get; set; }

            [MaxLength(2, ErrorMessage = "MaxLength 2 characters")]
            [Required(ErrorMessage = "This field is required!")]
            public string BloodType { get; set; }

            [MaxLength(1, ErrorMessage = "MaxLength 1 characters")]
            [Required(ErrorMessage = "This field is required!")]
            public string RHFactor { get; set; }

            public List<SelectListItem> BloodTypes { get; set; }
            public List<SelectListItem> RhFactors { get; set; }
            public int MedicalRecordId { get; set; }
        }
    }
}
