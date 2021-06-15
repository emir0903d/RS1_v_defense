using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PRENATALv2.Areas.Home.Models
{
    public class VSdata
    {
        public DateTime Date { get; set; }

        public float Temperature { get; set; }

        public int SystolicPressure { get; set; }

        public int DiastolicPressure { get; set; }

        public int HeartBeats { get; set; }

        public int RespiratoryRate { get; set; }

        public float Weight { get; set; }
    }
}
