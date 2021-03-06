using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Data
{
    public class ExpectedBirth
    {
        [Key]
        public int ExpectedBirthId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LastMenstrualDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExpectedDate { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }

        [ForeignKey(nameof(MedicalRecordId))]
        [Required(ErrorMessage = "This field is required!")]
        public MedicalRecord MedicalRecord { get; set; }
        public int MedicalRecordId { get; set; }
    }
}
