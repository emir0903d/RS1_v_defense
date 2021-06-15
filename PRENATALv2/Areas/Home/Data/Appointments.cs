using PRENATALv2.Areas.Home.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Data
{
    public class Appointments
    {
        [Key]
        public int AppointmentsId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }


        [ForeignKey(nameof(PatientId))]
        public AppUser Patient { get; set; }
        public int PatientId { get; set; }

        [ForeignKey(nameof(DoctorId))]
        public AppUser Doctor { get; set; }
        public int DoctorId { get; set; }
    }
}
