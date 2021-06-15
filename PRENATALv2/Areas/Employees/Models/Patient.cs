using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PRENATALv2.Areas.Home.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static PRENATALv2.Areas.Home.Models.AppUser;

namespace PRENATALv2.Areas.Employees.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        [StringLength(15, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required(ErrorMessage = "This field is required!")]
        public string Name { get; set; }

        [StringLength(30, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required(ErrorMessage = "This field is required!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "This field is mandatory!")]
        public string Gender { get; set; }
        public List<SelectListItem> Gender_List { get; set; }


        [MaxLength(50, ErrorMessage = "Maxlenght is 50 characters")]
        [RegularExpression("([a-zA-Z0-9]{1,})(\\@)([a-zA-Z]{1,})(\\.)([a-zA-Z]{2,3})", ErrorMessage = "Invalid e-mail format")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "This field is required!")]
        [Remote("IsEmailTaken", "RemoteValidation", "Admin", ErrorMessage = "E-mail in use!", HttpMethod = "POST", AdditionalFields = "Id, __RequestVerificationToken")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("(\\+)([0-9]{11,})", ErrorMessage = "Format:+38733111222")]
        [Remote("IsPhoneNumberTaken", "RemoteValidation", "Admin", ErrorMessage = "PhoneNumber in use!", HttpMethod = "POST", AdditionalFields = "Id, __RequestVerificationToken")]
        public string PhoneNumber { get; set; }
        [Required]
        public UserType Type { get; set; }
        public List<SelectListItem> Type_List { get; set; }
        public string MedicalRecordNumber { get; set; }
        [Required]
        public int? DoctorId { get; set; }
        public List<SelectListItem> Doctors { get; set; }
        public string Doctor { get; set; }
    }
}
