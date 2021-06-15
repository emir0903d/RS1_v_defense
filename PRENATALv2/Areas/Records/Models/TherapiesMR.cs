using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Records.Models
{
    public class TherapiesMR
    {
        public int MedicalRecordId { get; set; }
        public List<Details> Therapies { get; set; }

        public class Details
        {
            public int Id { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime BeginningDate { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime EndingDate { get; set; }

            [MaxLength(100, ErrorMessage = "MaxLength is 100 charachters!")]
            public string Medicaments { get; set; }

            [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
            public string Note { get; set; }

            public int MedicalRecordId { get; set; }
        }
    }
}
