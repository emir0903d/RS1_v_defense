using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Employees.Models
{
    public class Appointments
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public DateTime Time { get; set; }

        public string Note { get; set; }

        public int PatientId { get; set; }
        public string PatientsName { get; set; }
        public List<SelectListItem> Doctors {get; set;} 
        public int DoctorId { get; set; }
        public string DoctorsName { get; set; }
    }
}
