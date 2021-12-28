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
       public static frmTransferFunds frmtransferfunds;



        #endregion
        public Form1()
        {
            InitializeComponent();
            displayData();
            
         }

        DBAccess db = new DBAccess();

        private void displayData()
        {
            lblDonationAmount.Text ="Rs : " + Convert.ToString(db.TotalDonationAmount());
            lblTotalDialysisSessions.Text = db.TotalPatientSessions();
            lblTotalPatients.Text =Convert.ToString( db.TotalPatientsRegistered());
            lblZakatAmount.Text="Rs : " + db.TotalZakatEntry();
            totalKitsNumberDisplayLabel.Text = db.GetKetsData();
            lblClinicFundAmount.Text = "Rs : " + db.TotalClinicFund();

          
        }
        
        private void btnPatientView_Click(object sender, EventArgs e)
        {
            if (formPatient == null || formPatient.IsDisposed)
            {
                displayData();
                formPatient = new frmPatient();
                formPatient.Show();
            }
            formPatient.Show();
              formPatient.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (formDonation == null || formDonation.IsDisposed)
            {
                displayData();
                formDonation = new frmDonation();
                formDonation.Show();
            }
            
            formDonation.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (formExpense == null || formExpense.IsDisposed)
            {    displayData();
                formExpense = new frmExpense();
                formExpense.Show();
            }
              formExpense.BringToFront();
        }


        private void KetsButton_Click(object sender, EventArgs e)
        {
            if (ketform == null || ketform.IsDisposed)
            {
                displayData();
                ketform = new KetForm();
                ketform.Show();
            }
            ketform.BringToFront();

        }

        private void Zakat_Click(object sender, EventArgs e)
        {
            if(formZakat==null|| formZakat.IsDisposed)
            {
                displayData();
                formZakat=new frmZakat();
                formZakat.Show();

            }
            formZakat.BringToFront();

        }

        private void btnTransferFund_Click(object sender, EventArgs e)
        {
            if (frmtransferfunds == null || frmtransferfunds.IsDisposed)
            {
                displayData();
                frmtransferfunds = new frmTransferFunds();
                frmtransferfunds.Show();
            }
            frmtransferfunds.BringToFront();
        }


        private void btnDashboardView_Click(object sender, EventArgs e)
        {

            displayData();



        }

    }
    
}
