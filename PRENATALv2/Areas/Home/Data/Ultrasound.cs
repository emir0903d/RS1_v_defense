﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Data
{
    public class Ultrasound
    {
        [Key]
        public int UltrasoundId { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "This field is required!")]
        public DateTime Date { get; set; }

        public int HeartBeats { get; set; }

        public bool Movement { get; set; }

        public float Length { get; set; }

        public bool NuchalScan { get; set; }

        public bool Anomalies { get; set; }

        public float HeadDiameter { get; set; }

        public float HeadCircumference { get; set; }

        public float AbdominalCircumference { get; set; }

        public float FemurLength { get; set; }

        [MaxLength(255, ErrorMessage = "MaxLength is 255 charachters!")]
        public string Note { get; set; }

        [ForeignKey("MedicalRecord")]
        [Required(ErrorMessage = "This field is required!")]
        public int MedicalRecordId { get; set; }
        public MedicalRecord MedicalRecord { get; set; }
    }
}
