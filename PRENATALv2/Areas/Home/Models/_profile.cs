using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Models
{
    public class _profile
    {
        public int Id { get; set; }
        [StringLength(15, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required(ErrorMessage = "This field is required!")]
        public string Name { get; set; }
        [StringLength(30, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required(ErrorMessage = "This field is required!")]
        public string Surname { get; set; }
        [RegularExpression("([a-zA-Z0-9]{1,})(\\.{0,1})([a-zA-Z0-9]{1,})(\\@)([a-zA-Z]{1,})(\\.)([a-zA-Z]{2,3})", ErrorMessage = "Invalid e-mail format")]
        [Remote("IsEmailTaken", "RemoteValidation", "Admin", ErrorMessage = "E-mail in use!", HttpMethod = "POST", AdditionalFields = "Id, __RequestVerificationToken")]
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        [RegularExpression("(\\+)([0-9]{11,})", ErrorMessage = "Format:+38733111222")]
        [Remote("IsPhoneNumberTaken", "RemoteValidation", "Admin", ErrorMessage = "PhoneNumber in use!", HttpMethod = "POST", AdditionalFields = "Id, __RequestVerificationToken")]
        public string PhoneNumber { get; set; }
        public bool PhoneConfirmed { get; set; }
        public int LoginCount { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime LastLogin { get; set; }
        public bool TwoFactor {get; set;}
    }
}
