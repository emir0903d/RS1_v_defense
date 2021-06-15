using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Records.Models
{
    public class PhotosMR
    {
        public int MedicalRecordId { get; set; }
        public List<Details> Photos { get; set; }

        public class Details
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public byte[] Data { get; set; }
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime Date { get; set; }
            public string Base64Data { get; set; }
            public string DataURL { get; set; }
            public int MedicalRecordId { get; set; }
        }
    }
}
