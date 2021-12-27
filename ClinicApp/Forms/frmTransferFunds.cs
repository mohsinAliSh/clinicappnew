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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int amount=Convert.ToInt32(txtAmountTransfer.Text);
            db.TransferFunds(amount);
        }
    }
}
