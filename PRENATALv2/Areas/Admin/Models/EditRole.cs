using PRENATALv2.Areas.Home.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Admin.Models
{
    public class EditRole
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Required!")]
        public string RoleName { get; set; }
        public List<AppUser> ListOfUsers { get; set; }
    }
}
