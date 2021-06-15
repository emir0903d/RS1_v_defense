using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Data
{
    public class PregnancyLossHistory
    {
        [Key]
        public int PregnancyLossHistoryId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PregnancyLossDate { get; set; }

        [MaxLength(30, ErrorMessage = "MaxLength is 30 charachters!")]
        public string Type { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }

        [ForeignKey("MedicalRecord")]
        [Required(ErrorMessage = "This field is required!")]
        public int MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
    }
}
