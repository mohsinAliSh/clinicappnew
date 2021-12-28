using ClinicApp.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ClinicApp.Forms
{
    public partial class frmTransferFunds : Form
    {
        DBAccess db = new DBAccess();
        public frmTransferFunds()
        {
            InitializeComponent();
        }
        private bool CoustomValidating()
        {
            int i = 0;

            if (string.IsNullOrWhiteSpace(txtAmountTransfer.Text))
            {
                errorProviderTranfer.SetError(txtAmountTransfer, "please fill required field");
                i++;
            }
            if (string.IsNullOrWhiteSpace(cmbTransferType.Text))
            {
                errorProviderTranfer.SetError(cmbTransferType, "please fill required field");
                i++;
            }
            if (i > 0)
            {
                return true;
            }
            return false;
        }

            private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (CoustomValidating())
            {
                MessageBox.Show("Try Again!!!");
            }
            else
            {
                if (cmbTransferType.Text == "From Clinic To Bank")
                {
                    int amount = Convert.ToInt32(txtAmountTransfer.Text);
                    db.TransferFunds(amount);
                }
                if(cmbTransferType.Text=="From Bank To Clinic")
                {
                    int amount = Convert.ToInt32(txtAmountTransfer.Text);

                    db.TransferFundsToClinic(amount);
                }
            }
        }

    }
}
