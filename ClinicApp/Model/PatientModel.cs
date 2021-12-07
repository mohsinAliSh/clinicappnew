using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
   public class PatientModel
    {
        public int patientId { get; set; }
        public string pName { get; set; }
        public string pCnic { get; set; }
        public string pAddress { get; set; }
        public string pCity { get; set; }
        public string pCountry { get; set; }
        public string pContact { get; set; }
        public string pEmergencyContact { get; set; }
        public string pGender { get; set; }
        public string pMaritalStatus { get; set; }
        public string pEmail { get; set; }
        public DateTime pDob { get; set; }
        public string pActive { get; set; }
        public DateTime pCreatedDate { get; set; }
        public DateTime pModiefiedDate { get; set; }
    }
}
