using ClinicApp.BLL;
using ClinicApp.Model;
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
    public partial class frmPatient : Form
    {
        public DBAccess dBAccess = new DBAccess();
        public frmPatient()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //       new frmAddPatient().Show();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            LoadCurrentMonthPatients(DateTime.Now.Date);
        }

        private void LoadCurrentMonthPatients(DateTime date)
        {
            DataTable data = dBAccess.GetCurrentMonthPatients(date);

            if (data == null || data.Rows.Count == 0)
                return;

            for (int row = 0; row < data.Rows.Count; row++)
            {
                dgPatientList.Rows.Add();
                DataRow dataRow = data.Rows[row];
                dgPatientList.Rows[row].Cells["ID"].Value = Convert.ToInt32(dataRow["ID"]);
                dgPatientList.Rows[row].Cells["PatientName"].Value = Convert.ToString(dataRow["PatientName"]);
                dgPatientList.Rows[row].Cells["PatientCNIC"].Value = Convert.ToString(dataRow["PNIC"]);
                dgPatientList.Rows[row].Cells["Gender"].Value = Convert.ToString(dataRow["PGender"]);
                dgPatientList.Rows[row].Cells["MaritalStatus"].Value = Convert.ToString(dataRow["PMaritulStatus"]);
                dgPatientList.Rows[row].Cells["DOB"].Value = DateTime.Now;
                //dgPatientList.Rows[row].Cells["DOB"].Value =Convert.ToDateTime(dataRow["PDob"]).Date;
                dgPatientList.Rows[row].Cells["Contact"].Value = Convert.ToString(dataRow["PContact"]);
                dgPatientList.Rows[row].Cells["City"].Value = Convert.ToString(dataRow["PCity"]);
                dgPatientList.Rows[row].Cells["Country"].Value = Convert.ToString(dataRow["PCountry"]);
                dgPatientList.Rows[row].Cells["Address"].Value = Convert.ToString(dataRow["PAddress"]);

            }

            lblTotalPatients.Text = "Total : " + data.Rows.Count;
        }
        
        private void txtDoctorFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            test(sender, e);
        }

        public void test(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDonationAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            test(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PatientModel p = new PatientModel();
            //p.pName = txtPatientName.Text;// "new Patient";
            //p.pCreatedDate = DateTime.Now;
            //p.pActive = "1";
            //p.pAddress = rtPatientAddress.Text;
            //p.pCity = txtPatientCity.Text;
            //p.pCnic = txtPatientNic.Text;
            //p.pContact = txtPatientContact.Text;
            //p.pDob = DateTime.Now;
            //p.pEmail = txtPatientEmail.Text;
            //p.pEmergencyContact = txtPatientEmergencyContatact.Text;
            //p.pGender = cmbPatientGender.Text;
            //p.pMaritalStatus = cmbPatientMerital.Text;
            //p.pModiefiedDate = DateTime.Now;
            //p.pCountry = txtPatientCountry.Text;
            p.patientId = 1001;
            p.pName = "";// "new Patient";
            p.pCreatedDate = DateTime.Now;
            p.pActive = "1";
            p.pAddress = "";
            p.pCity = "";
            p.pCnic = "";
            p.pContact = "";
            p.pDob = DateTime.Now;
            p.pEmail = "";
            p.pEmergencyContact = "";
            p.pGender = "";
            p.pMaritalStatus = "";
            p.pModiefiedDate = DateTime.Now;
            p.pCountry = "";

            int feetype = 0;
            int kettype = 0;
            if (cmbPaymentType.Text == "Self") feetype = 1;
            else if (cmbPaymentType.Text == "Zakat") feetype = 2;
            else if (cmbPaymentType.Text == "Self+Zakt") feetype = 3;
            if (cmbKet.Text == "Self") kettype = 1;
            else if (cmbKet.Text == "Clinic") kettype = 2;
            else if (cmbKet.Text == "Zakat") kettype = 3;

            FeeEntryModel feeEntryModel = new FeeEntryModel();

            feeEntryModel.ClinicFee = Convert.ToDouble(txtClinicFee.Text);
            feeEntryModel.FeeType = feetype;
            feeEntryModel.KetAmount = Convert.ToDouble(txtKetAmount.Text);
            feeEntryModel.ZakatAmount = Convert.ToDouble(txtZakatAmount.Text);
            feeEntryModel.Date = Convert.ToDateTime(dtFeeDate.Text);
            feeEntryModel.Total = Convert.ToDouble(txtTotalAmount.Text);
            feeEntryModel.KetType = kettype;


            dBAccess.AddPatientData(p,feeEntryModel);

            
        //    dBAccess.AddFeeEntry(feeEntryModel);

        }
        
        private void txtPatientName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
