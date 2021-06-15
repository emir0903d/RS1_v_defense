using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Models
{
    public class AppRole:IdentityRole<int>
    {
        public int? NumberOfUsers { get; set; }

    }
}
