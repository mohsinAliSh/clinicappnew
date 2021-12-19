using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class DonatorEntryModel
    {
        public int DonatorID { get; set; }
        public string DonatorName { get; set; }
        public string DonatorCnic { get; set; }
        public string DonatorAddress { get; set; }
        public DateTime DonatorDate { get; set; }
    }
}
