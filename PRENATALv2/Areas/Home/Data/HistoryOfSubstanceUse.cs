using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Data
{
    public class HistoryOfSubstanceUse
    {
        [Key]
        public int HistoryOfSubstanceUseId { get; set; }

        [MaxLength(30, ErrorMessage = "MaxLength is 30 charachters!")]
        public string Description { get; set; }

        public bool PriorToPregnancy { get; set; }
        public bool StillUsing { get; set; }

        public int NumberOfYears { get; set; }


        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }

        [ForeignKey("MedicalRecord")]
        [Required(ErrorMessage = "This field is required!")]
        public int MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
    }
}
