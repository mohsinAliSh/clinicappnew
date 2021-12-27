using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.Model
{
    public class ExpenseEntryModel
    {
        public int expanseId { get; set; }
        public string expanseCatagory { get; set; }
        public string expanseDiscription { get; set; }
        public double expanseAmount { get; set; }
        public DateTime expanseDate { get; set; }
        public int expenseFrom { get; set; }
    }
}
