using ClinicApp.BLL;
using ClinicApp.Forms;
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
    public partial class KetForm : Form
    {

        public KetForm()
        {
            InitializeComponent();

        }
        DBAccess dBAccess = new DBAccess();
       

        public void LoadKetsQuantity(object sender, EventArgs e)
        {
            string TotalKetsAvailible = dBAccess.GetKetsData();
              
                totalKetsLabel.Text = TotalKetsAvailible;
          
        }
    

        private void KetsAddButton_Click(object sender, EventArgs e)
        {
            dBAccess.AddKets(Convert.ToInt32(NewKetsLabel.Text));
            NewKetsLabel.Clear();
            LoadKetsQuantity(sender,e);
        }


        private void NewKetsLabel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar!='-';
        }

    }
}
