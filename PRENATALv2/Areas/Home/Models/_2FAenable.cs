using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Models
{
    public class _2FAenable
    {
        //public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        public string SharedKey { get; set; }
        [Required]
        //[StringLength(7, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Text)]
        [Display(Name = "Verification Code")]
        public string Code { get; set; }
        public string AuthenticatorUri { get; set; }

    }
}
