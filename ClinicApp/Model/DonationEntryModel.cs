using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class DonationEntryModel
    {
       // public int DonationID { get; set; }
        public string DonatorType { get; set; }
        public int DonationAmount { get; set; }
        public string DonationRemarks { get; set; }
        public DateTime DonationDate { get; set; }

    }
}
