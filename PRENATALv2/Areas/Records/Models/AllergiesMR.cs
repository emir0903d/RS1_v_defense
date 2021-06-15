using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Records.Models
{
    public class AllergiesMR
    {
        public int MedicalRecordId { get; set; }
        public List<Details> AllergyList { get; set; }

        public class Details
        {
            public int Id { get; set; }
            [MaxLength(100, ErrorMessage = "MaxLength is 100 charachters!")]
            [Required(ErrorMessage = "This field is required!")]
            public string Type { get; set; }

            [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
            public string Note { get; set; }
            public int MedicalRecordId { get; set; }
        }
    }
}
