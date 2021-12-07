using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.Model;
using ClinicApp.BLL;

namespace ClinicApp.Forms
{
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
        }
        DBAccess dBAccess = new DBAccess();

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtExpenseAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        private void frm_expensedata(object sender, EventArgs e)
        {
            DataTable dt = dBAccess.GetExpenseData();

            if (dt == null || dt.Rows.Count == 0)
                return;

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                dgExpenseList.Rows.Add();
                DataRow dataRow = dt.Rows[row];
                dgExpenseList.Rows[row].Cells["ExpenseId"].Value = Convert.ToString(dataRow["ID"]);
                dgExpenseList.Rows[row].Cells["ExpenseAmount"].Value = Convert.ToString(dataRow["ExpenseAmount"]);
                dgExpenseList.Rows[row].Cells["ExpenseCategory"].Value = Convert.ToString(dataRow["ExpenseCategory"]);
                dgExpenseList.Rows[row].Cells["ExpenseDescription"].Value = Convert.ToString(dataRow["ExpenseDescription"]);
                dgExpenseList.Rows[row].Cells["ExpenseDate"].Value = DateTime.Now;
                //dgDonationList.Rows[row].Cells["DDate"].Value = Convert.ToString(dataRow["DataModified"]);
            }

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ExpenseEntryModel expense = new ExpenseEntryModel();
            expense.expanseAmount = double.Parse(txtExpenseAmount.Text);
            expense.expanseCatagory = cmbExpenseCategory.Text;
            expense.expanseDiscription = rtExpenseDescription.Text;
            dBAccess.AddExpanse(expense);
        }
      
    }
}
