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
            DonationEntryModel donation = new DonationEntryModel();
            donation.DonatorName = txtDonator.Text;
            donation.DonatorAddress = rtDonatorAddress.Text;
            donation.DonatorCnic = txtDonatorNic.Text;
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
                dgDonationList.Rows[row].Cells["donatorId"].Value = Convert.ToString(dataRow["ID"]);
                dgDonationList.Rows[row].Cells["DName"].Value = Convert.ToString(dataRow["DonatorName"]);
                dgDonationList.Rows[row].Cells["DNic"].Value = Convert.ToString(dataRow["DonatorNic"]);
                dgDonationList.Rows[row].Cells["DAddress"].Value = Convert.ToString(dataRow["DonatorAddress"]);
                dgDonationList.Rows[row].Cells["DDate"].Value = Convert.ToString(dataRow["DateModified"]);
            }

        }

    }
}
