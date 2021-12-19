using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class ZakatModel
    {
        public string ZakaterName { get; set; }
        public string ZakaterNic { get; set; }
        public string ZakaterAddress { get; set; }
        public string ZakaterType { get; set; }
        public double ZakatAmount { get; set; }
        public DateTime ZakatDate { get; set; }
        public string ZakatRemarks { get; set; }

    }
}
