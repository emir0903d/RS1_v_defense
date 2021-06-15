using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Admin.Models
{
    public class CreateRole
    {
        [Required(ErrorMessage = "Required!")]
        public string RoleName { get; set; }
    }
}
