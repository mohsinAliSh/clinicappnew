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
        }
        DBAccess db = new DBAccess();
        private void btnSave_Click(object sender, EventArgs e)
        {
            DonatorEntryModel donator = new DonatorEntryModel();
            donator.DonatorName = txtDonator.Text;
            donator.DonatorAddress = rtDonatorAddress.Text;
            donator.DonatorCnic = txtDonatorNic.Text;
            db.AddDonator(donator);

            DonationEntryModel donation = new DonationEntryModel();
            donation.DonatorType = cmbDonatorType.Text;
            donation.DonationAmount =Convert.ToInt32(txtDonationAmount.Text);
            donation.DonationRemarks = rtDonationRemark.Text;
            donation.DonationDate =Convert.ToDateTime(dtDonationDate.Text);
            //    donation.DonationID=Convert.ToInt32(lblDonatorID.Text);
            db.AddDonation(donation);


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
                dgDonationList.Rows[row].Cells["DDate"].Value = Convert.ToString(dataRow["DonaitonDate"]);
            }

        }

    }
}
