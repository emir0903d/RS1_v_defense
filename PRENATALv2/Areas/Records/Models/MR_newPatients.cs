﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Records.Models
{
    public class MR_newPatients
    {
        [Required(ErrorMessage = "Required!")]
        public int ChoosenPatientId { get; set; }
        public List<SelectListItem> NewP_List { get; set; }
        public List<PatientDetails> NewP_Details { get; set; }

        public class PatientDetails
        {
            public int Id { get; set; }
            public int? DoctorId { get; set; }
            public string Doctor { get; set; }
            public string Name { get; set; }
            public string Surname { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
        }
        public string MedicalRecordNumber { get; set; }
        [StringLength(13, ErrorMessage = "Length must be 13 numbers", MinimumLength = 13)]
        [Required(ErrorMessage = "This field is required!")]
        [Remote("IsPINTaken", "RemoteValidation", "Admin", ErrorMessage = "PIN in use!", HttpMethod = "POST", AdditionalFields = "Id, __RequestVerificationToken")]
        public string PersonalIdentificationNumber { get; set; }
        [MaxLength(30, ErrorMessage = "MaxLength is 30 characters")]
        public string MaidenName { get; set; }
        [MaxLength(15, ErrorMessage = "MaxLength 10 characters")]
        [Required(ErrorMessage = "This field is required!")]
        public string MartialStatus { get; set; }
        public List<SelectListItem> StatusList { get; set; }
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "This field is required!")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
        [MaxLength(2, ErrorMessage = "MaxLength 2 characters")]
        [Required(ErrorMessage = "This field is required!")]
        public string BloodType { get; set; }
        public List<SelectListItem> BloodTypes { get; set; }
        [MaxLength(1, ErrorMessage = "MaxLength 1 characters")]
        [Required(ErrorMessage = "This field is required!")]
        public string RhFactor { get; set; }
        public List<SelectListItem> RhFactors { get; set; }
    }
}
