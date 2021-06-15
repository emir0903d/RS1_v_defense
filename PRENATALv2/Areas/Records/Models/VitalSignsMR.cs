using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Records.Models
{
    public class VitalSignsMR
    {
        public int MedicalRecordId { get; set; }
        public List<Details> VitalSigns { get; set; }

        public class Details
        {
            public int Id { get; set; }

            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime Date { get; set; }

            public float Temperature { get; set; }

            public int SystolicPressure { get; set; }

            public int DiastolicPressure { get; set; }

            public int HeartBeats { get; set; }

            public int RespiratoryRate { get; set; }

            public float Height { get; set; }

            public float Weight { get; set; }

            [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
            public string Note { get; set; }

            public int MedicalRecordId { get; set; }
        }
    }
}
