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
    public partial class frmDonation : Form
    {
        public frmDonation()
        {
            InitializeComponent();
            DonatorTableData();
            SearchDonatorNames();
        }
        DBAccess db = new DBAccess();
        List<DonatorEntryModel> donatorEntry = new List<DonatorEntryModel>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CoustomValidating())
            {
                MessageBox.Show("Enter Data Correctly");
            }
            else
            {
                SaveDonationEntryData();
            }

        }
        private void frm_DonatorInfo(object sender, EventArgs e)
        {
            DataTable dt = db.GetDonatorInfo();

            if (dt == null || dt.Rows.Count == 0)
                return;

            for (int row = 0; row < dt.Rows.Count; row++)
            {
                dgDonationList.Rows.Add();
                DataRow dataRow = dt.Rows[row];
                dgDonationList.Rows[row].Cells["DName"].Value = Convert.ToString(dataRow["DonatorName"]);
                dgDonationList.Rows[row].Cells["DAmount"].Value = Convert.ToString(dataRow["DonationAmount"]);
                dgDonationList.Rows[row].Cells["DRemarks"].Value = Convert.ToString(dataRow["Remarks"]);
                dgDonationList.Rows[row].Cells["DDate"].Value = Convert.ToString(dataRow["DonationDate"]);
            }

        }
        private void tsbClear_Click(object sender, EventArgs e)
        {
            AssignDefaultValues();
        }
        private void btnDonatorFetch_Click(object sender, EventArgs e)
        {
            FetchDonatorData();
        }
        private void txtDonatorSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonatorSearch.Text))
            {
                AssignDefaultValues();
            }
        }
        private bool CoustomValidating()
        {
            int i = 0;

            if (string.IsNullOrWhiteSpace(cmbDonatorType.Text))
             {
                    errorProviderDonation.SetError(cmbDonatorType, "please fill required field");
                    i++;
             }
            if (string.IsNullOrWhiteSpace(txtDonationAmount.Text) || txtDonationAmount.Text == "0")
            {
                errorProviderDonation.SetError(txtDonationAmount, "please fill required field");
                i++;
            }
            if (i > 0)
            {
                return true;
            }
            return false;

        }
        private void SaveDonationEntryData()
        {
            DonatorEntryModel donator = new DonatorEntryModel();
            DonationEntryModel donation = new DonationEntryModel();
            donator.DonatorName = txtDonator.Text;
            donator.DonatorAddress = rtDonatorAddress.Text;
            donator.DonatorCnic = txtDonatorNic.Text;
            donation.DonatorType = cmbDonatorType.Text;
            donation.DonationAmount = Convert.ToInt32(txtDonationAmount.Text);
            donation.DonationRemarks = rtDonationRemark.Text;
            donation.DonationDate = Convert.ToDateTime(dtDonationDate.Text);
            //    donation.DonationID=Convert.ToInt32(lblDonatorID.Text);
            if (lblDonatorID.Text == "New")
            {
                donator.DonatorID = 0;
            }
            else
            {
                donator.DonatorID = Convert.ToInt32(lblDonatorID.Text);
            }
            db.AddDonator(donator,donation);
            AssignDefaultValues();
        }
        private void AssignDefaultValues()
        {
            lblDonatorID.Text = "New";
            txtDonator.Clear();
            txtDonatorNic.Clear();
            rtDonatorAddress.Clear();
            cmbDonatorType.ResetText();
            txtDonationAmount.Clear();
            rtDonationRemark.Clear();

        }
        private void FetchDonatorData()
        {
            try { 
            donatorEntry.ForEach(s =>
            {
                if (s.DonatorName == txtDonatorSearch.Text)
                {
                    lblDonatorID.Text = Convert.ToString(s.DonatorID);
                    txtDonator.Text=s.DonatorName;
                    txtDonatorNic.Text = s.DonatorCnic;
                    rtDonatorAddress.Text = s.DonatorAddress;

                }
            });
            }
            catch (Exception)
            {
                MessageBox.Show("error while fetching");
            }
        }
        private void DonatorTableData()
        {
            donatorEntry.Clear();
            DataTable data = db.AllDonators();
            if (data == null || data.Rows.Count == 0)
                return;

            for (int row = 0; row < data.Rows.Count; row++)
            {
                DataRow dataRow = data.Rows[row];
                DonatorEntryModel d = new DonatorEntryModel();
                d.DonatorID=Convert.ToInt32( dataRow["ID"]);
                d.DonatorName = Convert.ToString(dataRow["DonatorName"]);
                d.DonatorCnic = Convert.ToString(dataRow["DonatorNic"]);
                d.DonatorAddress = Convert.ToString(dataRow["DonatorAddress"]);
                donatorEntry.Add(d);
            }

        }
        private void SearchDonatorNames()
        {
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(donatorEntry.AsEnumerable().Select(r => r.DonatorName).ToArray());
            txtDonatorSearch.AutoCompleteCustomSource = autoComplete;
        }

    }
}
