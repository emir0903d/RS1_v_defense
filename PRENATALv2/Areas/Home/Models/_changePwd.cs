using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Models
{
    public class _changePwd
    {
        public int? UserId { get; set; }
        [Remote("IsPasswordCorrect", "RemoteValidation", "Admin", HttpMethod = "POST", ErrorMessage = "Wrong password!", AdditionalFields = "UserId, __RequestVerificationToken")]
        public string _currentPassword { get; set; }
        [RegularExpression("^(?=.*?[A-Z])(?=(.*[a-z]){1,})(?=(.*[\\d]){1,})(?=(.*[\\W]){1,})(?!.*\\s).{8,}$", ErrorMessage = "Error!")]
        public string _newPassword { get; set; }
        [Remote("ArePasswordsTheSame", "RemoteValidation", "Admin", HttpMethod = "POST", ErrorMessage = "Wrong password!", AdditionalFields = "_newPassword, __RequestVerificationToken")]
        public string _confirmPassword { get; set; }
    }
}
