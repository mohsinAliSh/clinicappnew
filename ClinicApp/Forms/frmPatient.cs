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
            patientnamesuggestions();
            SearchPatientNames();
            tabControl1.SelectedIndex = 1;

        }

        public List<PatientModel> patientdata = new List<PatientModel>();

        private void frmPatient_Load(object sender, EventArgs e)
        {
            LoadCurrentMonthPatients(DateTime.Now.Date);
        }

        private void LoadCurrentMonthPatients(DateTime date)
        {
            dgPatientList.Rows.Clear();
            double zakatamount = 0;
            double clinicamount = 0;
            lblTotalPatients.Text = "Total : 0";
            lblzakatsum.Text = "Total Zakat Amount :  0";
            lblclinicsum.Text = "Total Clinic Fee :  0";
            DataTable data = dBAccess.GetCurrentMonthPatients(date);
            if (data == null || data.Rows.Count == 0)
                return;

            for (int row = 0; row < data.Rows.Count; row++)
            {

             
                dgPatientList.Rows.Add();
                DataRow dataRow = data.Rows[row];
                zakatamount +=Convert.ToDouble( dataRow["DonationAmount"]);
                clinicamount += Convert.ToDouble(dataRow["ClinicalFee"]);

                dgPatientList.Rows[row].Cells["PatientName"].Value = Convert.ToString(dataRow["PatientName"]);
                dgPatientList.Rows[row].Cells["PatientCNIC"].Value = Convert.ToString(dataRow["PNIC"]);
                dgPatientList.Rows[row].Cells["Gender"].Value = Convert.ToString(dataRow["PGender"]);
                dgPatientList.Rows[row].Cells["Contact"].Value = Convert.ToString(dataRow["PContact"]);
                dgPatientList.Rows[row].Cells["ZakatAmount"].Value = Convert.ToString(dataRow["DonationAmount"]);
                //dgPatientList.Rows[row].Cells["DOB"].Value =Convert.ToDateTime(dataRow["PDob"]).Date;
               // dgPatientList.Rows[row].Cells["KetAmount"].Value = Convert.ToString(dataRow["KetAmount"]);
                dgPatientList.Rows[row].Cells["ClinicFee"].Value = Convert.ToString(dataRow["ClinicalFee"]);
                dgPatientList.Rows[row].Cells["TotalAmount"].Value = Convert.ToString(dataRow["NetFee"]);
                dgPatientList.Rows[row].Cells["Date"].Value = Convert.ToDateTime(dataRow["EntryDate"]);

            
            }
            

            lblTotalPatients.Text = "Total : " + data.Rows.Count;
           lblzakatsum.Text ="Total Zakat Amount : " +  Convert.ToString(zakatamount);
            lblclinicsum.Text = "Total Clinic Fee : " +  Convert.ToString(clinicamount);

        }
        
        public void test(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDonationAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            test(sender, e);
        }

        private void patientnamesuggestions()
        {
            patientdata.Clear();
           // var patientnames = new List<string>();
            DataTable data = dBAccess.GetAllPatients();
            //dataTable.AsEnumerable().Select((r) {
            //     return    r.Field<string>("PatientName")
            //     } ).ToList();

            if (data == null || data.Rows.Count == 0)
                return;

            for (int row = 0; row < data.Rows.Count; row++)
            {
                //dgPatientList.Rows.Add();
                DataRow dataRow = data.Rows[row];
                PatientModel p = new PatientModel();
                p.patientId = Convert.ToInt32(dataRow["ID"]);
                p.pName = Convert.ToString(dataRow["PatientName"]);
                p.pCnic = Convert.ToString(dataRow["PNIC"]);
                p.pGender = Convert.ToString(dataRow["PGender"]);
                p.pMaritalStatus = Convert.ToString(dataRow["PMaritulStatus"]);
                p.pCreatedDate = DateTime.Now;
                p.pContact= Convert.ToString(dataRow["PContact"]);
                p.pCity= Convert.ToString(dataRow["PCity"]);
                p.pCountry= Convert.ToString(dataRow["PCountry"]);
                p.pAddress= Convert.ToString(dataRow["PAddress"]);
                p.pEmergencyContact = Convert.ToString(dataRow["PEmergencyContact"]);
                p.pEmail = Convert.ToString(dataRow["PEmail"]);
                p.pDob =Convert.ToDateTime( dataRow["PDob"]);

                patientdata.Add(p);
            }

        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (coustomValidating())
            {

                MessageBox.Show("Enter Data Correctly");
            }
            else
            {

                SaveFormDataToModel();

                
            }
        }
        private void SaveFormDataToModel()
        {

            PatientModel p = new PatientModel();
            FeeEntryModel feeEntryModel = new FeeEntryModel();
            p.pName = txtPatientName.Text;
            p.pCreatedDate = DateTime.Now;
            p.pActive = "1";
            p.pAddress = rtPatientAddress.Text;
            p.pCity = txtPatientCity.Text;
            p.pCnic = txtPatientNic.Text;
            p.pContact = txtPatientContact.Text;
            p.pDob = DateTime.Now;
            p.pEmail = txtPatientEmail.Text;
            p.pEmergencyContact = txtPatientEmergencyContatact.Text;
            p.pGender = cmbPatientGender.Text;
            p.pMaritalStatus = cmbPatientMerital.Text;
            p.pModiefiedDate = DateTime.Now;
            p.pCountry = txtPatientCountry.Text;
            int feetype = 0;
            int kettype = 0;
            if (cmbPaymentType.Text == "Self") feetype = 1;
            else if (cmbPaymentType.Text == "Zakat") feetype = 2;
            else if (cmbPaymentType.Text == "Self+Zakat") feetype = 3;
            if (cmbKet.Text == "Self") kettype = 1;
            else if (cmbKet.Text == "Clinic") kettype = 2;
            feeEntryModel.ClinicFee = Convert.ToDouble(txtClinicFee.Text);
            feeEntryModel.FeeType = feetype;
            feeEntryModel.KetType = kettype;
            feeEntryModel.ZakatAmount = Convert.ToDouble(txtZakatAmount.Text);
            feeEntryModel.Date = Convert.ToDateTime(dtFeeDate.Value);
            feeEntryModel.Total = Convert.ToDouble(txtTotalAmount.Text);
            feeEntryModel.KetAmount = Convert.ToDouble(txtKetAmount.Text);

            if (lblPatientID.Text == "New")
            {
                p.patientId = 0;
            }
            else
            {
                p.patientId = Convert.ToInt32(lblPatientID.Text);
            }

            dBAccess.AddPatientData(p, feeEntryModel);
            AssignDefaultValues();
            LoadCurrentMonthPatients(DateTime.Now.Date);


        }
        
        private void AssignDefaultValues()
        {
            txtPatientName.Clear();
            txtPatientContact.Clear();
            txtPatientEmail.Clear();
            txtPatientNic.Clear();
            txtPatientCity.Clear();
            lblPatientID.Text = "New";
            txtPatientCountry.Clear();
            txtPatientEmergencyContatact.Clear();
            rtPatientAddress.Clear();
            dtPatientDOB.Value=DateTime.Now;
            cmbPatientGender.ResetText();
            cmbPatientMerital.ResetText();
            cmbPaymentType.ResetText();
            cmbKet.ResetText();
            txtClinicFee.Text = "0";
            txtZakatAmount.Text = "0";
            txtClinicFee.ReadOnly = false;
            txtZakatAmount.ReadOnly = false;
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            AssignDefaultValues();
        }

        private void SearchPatientNames()
        {
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(patientdata.AsEnumerable().Select(r => r.pName).ToArray());
            txtpatientsearch.AutoCompleteCustomSource = autoComplete;
        }
        
        private void FetchDataFromPatient()
        {
            try
            {

                patientdata.ForEach(r => {
                    if (r.pName == txtpatientsearch.Text)
                    {
                        cmbPatientGender.ResetText();
                        cmbPatientMerital.ResetText();
                        cmbPatientGender.SelectedText = r.pGender;
                        cmbPatientMerital.SelectedText = r.pMaritalStatus;
                        txtPatientName.Text = r.pName;
                        txtPatientNic.Text = r.pCnic;
                        txtPatientCity.Text = r.pCity;
                        lblPatientID.Text = Convert.ToString(r.patientId);
                        txtPatientContact.Text = r.pContact;
                        txtPatientEmail.Text = r.pEmail;
                        txtPatientNic.Text = r.pCnic;
                        txtPatientCountry.Text = r.pCountry;
                        txtPatientEmergencyContatact.Text = r.pEmergencyContact;
                        rtPatientAddress.Text = r.pAddress;
                        dtPatientDOB.Value = r.pDob;


                    }
                });

            }
            catch (Exception) { }

        }

        private bool coustomValidating()
        {
            List<Control> controls = new List<Control>();
            controls.Add(txtPatientName);
            controls.Add(txtPatientNic);
            controls.Add(cmbKet);
            controls.Add(cmbPaymentType);
            int i = 0;
            foreach (var control in controls)
            {
                
                if (string.IsNullOrWhiteSpace(control.Text))
                {
                    errorProviderPForm.SetError(control, "please fill required field");
                    i++;
                }  
            }
            if (cmbPaymentType.Text =="Self")
            {
                if (txtClinicFee.Text == "0")
                {
                    errorProviderPForm.SetError(txtClinicFee, "please fill required field");
                    i++;
                }
            }
            if(cmbPaymentType.Text == "Zakat")
            {
                if (txtZakatAmount.Text == "0")
                {
                    errorProviderPForm.SetError(txtZakatAmount, "please fill required field");
                    i++;
                }

            }
            if (cmbPaymentType.Text == "Self+Zakat")
            {
                if (txtClinicFee.Text == "0")
                {
                    errorProviderPForm.SetError(txtClinicFee, "please fill required field");
                    i++;
                }
                if (txtZakatAmount.Text == "0")
                {
                    errorProviderPForm.SetError(txtZakatAmount, "please fill required field");
                    i++;
                }

            }
            if (i > 0)
            {
                return true;
            }
            return false;

        }

        private void btpatientinfofetcher_Click(object sender, EventArgs e)
        {
            
            FetchDataFromPatient();
        }

        private void txtpatientsearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtpatientsearch.Text))
            {
                AssignDefaultValues();
            }
        }
        private void CalculateSum()
        {
            try
            {
                
                txtTotalAmount.Text = Convert.ToString
                    ((Convert.ToInt32(txtZakatAmount.Text)) + (Convert.ToInt32(txtKetAmount.Text)) + (Convert.ToInt32(txtClinicFee.Text)));
            }
            catch (Exception)
            {
                txtTotalAmount.Text = "0";
            }
        }

        private void txtZakatAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void txtClinicFee_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void txtKetAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateSum();
        }

        private void cmbPaymentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbPaymentType.SelectedIndex == 2)
            {
                txtKetAmount.Text="0";
                txtKetAmount.ReadOnly = true;

            }
            else
            {
                txtKetAmount.ReadOnly = false;
            }
            if (cmbPaymentType.SelectedIndex == 0)
            {
                txtZakatAmount.Text = "0";
                txtZakatAmount.ReadOnly = true;
            }
            else
            {
                txtZakatAmount.ReadOnly = false;
            }
            if(cmbPaymentType.SelectedIndex == 1)
            {
                txtClinicFee.Text = "0";
                txtClinicFee.ReadOnly = true;
            }
            else
            {
                txtClinicFee.ReadOnly= false;
            }
        }

        private void txtClinicFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            test(sender, e);
        }

        private void txtKetAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            test(sender, e);
        }

        private void btnDashFilter_Click(object sender, EventArgs e)
        {
            LoadCurrentMonthPatients(dtStartDate.Value);
        }

    }
}
