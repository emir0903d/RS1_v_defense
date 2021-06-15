using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Records.Models
{
    public class SubstancesUseMR
    {
        public int MedicalRecordId { get; set; }
        public List<Details> Substances { get; set; }

        public class Details
        {
            public int Id { get; set; }

            [MaxLength(30, ErrorMessage = "MaxLength is 30 charachters!")]
            public string Description { get; set; }

            public bool PriorToPregnancy { get; set; }
            public bool StillUsing { get; set; }

            public int NumberOfYears { get; set; }


            [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
            public string Note { get; set; }

            public int MedicalRecordId { get; set; }
        }
    }
}
