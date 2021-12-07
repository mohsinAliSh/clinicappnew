using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicApp;

namespace ClinicApp.Model
{
    public class FeeEntryModel
    {
        public string FeeType { get; set; }
        public double ZakatAmount { get; set; }
        public DateTime Date { get; set; }
        public string Ket { get; set; }
        public double ClinicFee { get; set; }
        public double KetAmount { get; set; }
        public double Total { get; set; }
    }
}
