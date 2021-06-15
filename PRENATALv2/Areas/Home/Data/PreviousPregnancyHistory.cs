using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Data
{
    public class PreviousPregnancyHistory
    {
        [Key]
        public int PreviousPregnancyHistoryId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PregnancyDate { get; set; }

        public int GestationWeeks { get; set; }

        [MaxLength(30, ErrorMessage = "MaxLength is 30 charachters!")]
        public string DeliveryType { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Complications { get; set; }

        [MaxLength(50, ErrorMessage = "MaxLength is 50 charachters!")]
        public string Outcome { get; set; }

        [ForeignKey("MedicalRecord")]
        [Required(ErrorMessage = "This field is required!")]
        public int MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
    }
}
