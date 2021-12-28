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
using System.Threading;

namespace ClinicApp.Forms
{
    public partial class frmExpense : Form
    {
        public frmExpense()
        {
            InitializeComponent();
        }
        DBAccess dBAccess = new DBAccess();


        private void frm_expensedata(object sender, EventArgs e)
        {
            GetCurrentMonthExpense(DateTime.Now.Date);

        }

        private void GetCurrentMonthExpense(DateTime date)
        {
            dgExpenseList.Rows.Clear();
            int expenseamount = 0;
            lblTotalAmount.Text = "Total Amount : 0";
            DataTable dt = dBAccess.GetExpenseData(date);

            if (dt == null || dt.Rows.Count == 0)
                return;

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                List<string> expenseFrom = new List<string>();
                dgExpenseList.Rows.Add();
                DataRow dataRow = dt.Rows[row];
                dgExpenseList.Rows[row].Cells["ExpenseAmount"].Value = Convert.ToString(dataRow["ExpenseAmount"]);
                dgExpenseList.Rows[row].Cells["ExpenseCategory"].Value = Convert.ToString(dataRow["ExpenseCategory"]);
                dgExpenseList.Rows[row].Cells["ExpenseDescription"].Value = Convert.ToString(dataRow["ExpenseDescription"]);
                dgExpenseList.Rows[row].Cells["ExpenseDate"].Value = Convert.ToString(dataRow["ExpenseDate"]);
                dgExpenseList.Rows[row].Cells["ExpenseFrom"].Value = Convert.ToString(dataRow["ExpenseFrom"]);
                expenseamount+= Convert.ToInt32(dataRow["ExpenseAmount"]);
            }
            lblTotalAmount.Text = "Total Amount : " + expenseamount;
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (CoustomValidating())
            {
                MessageBox.Show("Enter Data!");
            }
            else
            {
                int expenseFromID=0;
                ExpenseEntryModel expense = new ExpenseEntryModel();
                expense.expanseAmount = double.Parse(txtExpenseAmount.Text);
                expense.expanseCatagory = cmbExpenseCategory.Text;
                expense.expanseDiscription = rtExpenseDescription.Text;
                expense.expanseDate =Convert.ToDateTime(dateTimePicker1.Text);
                if(cmbExpenseFrom.Text=="Clinic Fund")
                {
                    expenseFromID = 1;
                }
                if(cmbExpenseFrom.Text=="Donation Fund")
                {
                    expenseFromID = 2;
                }
                expense.expenseFrom = expenseFromID;
                dBAccess.AddExpanse(expense);
                AssignDefaultValues();
                GetCurrentMonthExpense(DateTime.Now.Date);

               
            }
        }
        private bool CoustomValidating()
        {
            int i = 0;

            if (string.IsNullOrWhiteSpace(cmbExpenseCategory.Text))
            {
                errorProviderExpense.SetError(cmbExpenseCategory, "please fill required field");
                i++;
            }
            if (string.IsNullOrWhiteSpace(cmbExpenseFrom.Text))
            {
                errorProviderExpense.SetError(cmbExpenseFrom, "please fill required field");
                i++;
            }
            if (string.IsNullOrWhiteSpace(txtExpenseAmount.Text) || txtExpenseAmount.Text == "0")
            {
                errorProviderExpense.SetError(txtExpenseAmount, "please fill required field");
                i++;

            }
            {


            }
            if (i > 0)
            {
                return true;
            }
            return false;

        }

        private void txtExpenseAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void AssignDefaultValues()
        {
            txtExpenseAmount.Clear();
            cmbExpenseCategory.ResetText();
            cmbExpenseFrom.ResetText();
            rtExpenseDescription.Clear();
        }
        
        private void tabClick()
        {

           Form1.formExpense.Dispose();
                Form1.formExpense = new frmExpense();
                Form1.formExpense.Show();
            
       //     Form1.formExpense.BringToFront();
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            AssignDefaultValues
                ();
        }

        private void btnDashFilter_Click(object sender, EventArgs e)
        {
            GetCurrentMonthExpense(dtStartDate.Value);
            
        }
    }
}
