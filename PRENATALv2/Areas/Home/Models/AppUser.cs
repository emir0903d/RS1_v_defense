using Microsoft.AspNetCore.Identity;
using PRENATALv2.Areas.Home.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Models
{
    public class AppUser:IdentityUser<int>
    {
        public virtual MedicalRecord MedicalRecord { get; set; }

        [StringLength(15, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required(ErrorMessage = "This field is required!")]
        public string Name { get; set; }

        [StringLength(30, ErrorMessage = "Length must be between 2 and 15 characters", MinimumLength = 2)]
        [Required(ErrorMessage = "This field is required!")]
        public string Surname { get; set; }

        [MaxLength(6, ErrorMessage = "MaxLength is 6 characters")]
        public string Gender { get; set; }

        public UserStatus Status { get; set; }
        public enum UserStatus
        {
            Approved,
            Rejected
        }

        public UserType Type { get; set; }

        public enum UserType
        {
            Admin,
            Doctor,
            Nurse,
            Patient,
            Pending
        }
        public int? DoctorId { get; set; }
        

        public int LoginCount { get; set; }
        public DateTime RegDate { get; set; }
        public DateTime LoginDate { get; set; }

    }
}
