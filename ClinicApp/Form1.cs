using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.BLL;
using ClinicApp.Forms;

namespace ClinicApp
{
    
    public partial class Form1 : Form
    {
        #region Variables

       public static frmPatient formPatient;
       public static frmDonation formDonation;
       public static frmExpense formExpense;
        public static KetForm ketform;
        public static KetForm kf;
        public static frmZakat formZakat;

        #endregion
        public Form1()
        {
            InitializeComponent();
            
         }

        DBAccess db = new DBAccess();

        
        
        private void btnPatientView_Click(object sender, EventArgs e)
        {
            if (formPatient == null || formPatient.IsDisposed)
            {
                formPatient = new frmPatient();
                formPatient.Show();
            }
            formPatient.Show();
              formPatient.BringToFront();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (formDonation == null || formDonation.IsDisposed)
            {
                formDonation = new frmDonation();
                formDonation.Show();
            }
            
            formDonation.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (formExpense == null || formExpense.IsDisposed)
            {
                formExpense = new frmExpense();
                formExpense.Show();
            }
              formExpense.BringToFront();
        }


        private void KetsButton_Click(object sender, EventArgs e)
        {
            if (ketform == null || ketform.IsDisposed)
            {
                ketform = new KetForm();
                ketform.Show();
            }
            ketform.BringToFront();

        }

       void totalkits(object sender, EventArgs e)
        {
            totalKitsNumberDisplayLabel.Text = db.GetKetsData();
        }
        private void Zakat_Click(object sender, EventArgs e)
        {
            if(formZakat==null|| formZakat.IsDisposed)
            {
                formZakat=new frmZakat();
                formZakat.Show();

            }
            formZakat.BringToFront();

        }
    }
    
}
