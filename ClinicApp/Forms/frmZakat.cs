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
    public partial class frmZakat : Form
    {
        public frmZakat()
        {
            InitializeComponent();
            ZakaterTableData();
            SearchZakaterNames();
            AssignDefaultValues();

        }
        DBAccess db = new DBAccess();
        List<ZakatModel> zakatentry = new List<ZakatModel>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CoustomValidating())
            {
                MessageBox.Show("Entry Data!");

            }
            else { 
            ZakatModel zakat = new ZakatModel();
            zakat.ZakaterName=txtZakaterName.Text;
            zakat.ZakaterNic = txtZakaterNic.Text;
            zakat.ZakaterAddress = rtZakaterAddress.Text;
            zakat.ZakatAmount=Convert.ToDouble( txtZakatAmount.Text);
            zakat.ZakaterType = cmbZakaterType.Text;
            zakat.ZakatDate =Convert.ToDateTime( dtZakatDate.Text);
            zakat.ZakatRemarks = rtZakatRemark.Text;
                if (lblZakaterID.Text == "New")
                {
                    zakat.Id = 0;
                }
                else
                {
                    zakat.Id = Convert.ToInt32(lblZakaterID.Text);
                }
                db.AddZakat(zakat);
            AssignDefaultValues();
                
                GetCurrentMonthZakat(DateTime.Now.Date);
            }
        }
    
        private void frm_ZakatInfo(object sender, EventArgs e)
        {
            GetCurrentMonthZakat(DateTime.Now.Date);

        }
        private void GetCurrentMonthZakat(DateTime date)
        {
            dgZakatList.Rows.Clear();
            double totalzakatcredit = 0;
            double totalzakatDebit = 0;
            double totalcliniczakat = 0;
            lbldgzakatcredit.Text = "Total Credit :  0";
            totallbldgzakatdebit.Text = "Total Debit :  0";
            DataTable dataTable = db.GetZakatInfo(date);
            if (dataTable == null || dataTable.Rows.Count == 0)
                return;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {

                dgZakatList.Rows.Add();
                DataRow dataRow = dataTable.Rows[i];
                dgZakatList.Rows[i].Cells["ZakaterName"].Value = dataRow["ZakaterName"];

                if (Convert.ToString(dataRow["ZakaterType"]) == "Clinic Zakat")
                {
                    dgZakatList.Rows[i].Cells["ClinicZakat"].Value = dataRow["ZakatAmount"];
                    dgZakatList.Rows[i].Cells["ZakatCredit"].Value = "-";
                    dgZakatList.Rows[i].Cells["ZakatDebit"].Value = "-";
                    totalcliniczakat += Convert.ToDouble(dataRow["ZakatAmount"]);
                }
                else { 
                    if (Convert.ToDouble(dataRow["ZakatAmount"]) > 0)
                    {
                        dgZakatList.Rows[i].Cells["ZakatCredit"].Value = dataRow["ZakatAmount"];
                        dgZakatList.Rows[i].Cells["ZakatDebit"].Value = "-";
                        totalzakatcredit += Convert.ToDouble(dataRow["ZakatAmount"]);
                        dgZakatList.Rows[i].Cells["ClinicZakat"].Value = "-";


                    }
                    else
                    {
                        dgZakatList.Rows[i].Cells["ZakatDebit"].Value = -1 * Convert.ToDouble(dataRow["ZakatAmount"]);
                        dgZakatList.Rows[i].Cells["ZakatCredit"].Value = "-";
                        totalzakatDebit += (-1 * Convert.ToDouble(dataRow["ZakatAmount"]));
                        dgZakatList.Rows[i].Cells["ClinicZakat"].Value = "-";


                    }
                }
                if (Convert.ToString(dataRow["ZakaterType"]) == "Bank Zakat")
                    //  dgZakatList.Rows[i].Cells["ZakatAmount"].Value = dataRow["ZakatAmount"];
                    dgZakatList.Rows[i].Cells["ZakatRemarks"].Value = dataRow["ZakaterRemarks"];
                dgZakatList.Rows[i].Cells["ZakatDate"].Value = dataRow["ZakatDate"];
            }
            lblClinicZakatTotal.Text ="Total Clinic Zakat : " + Convert.ToString(totalcliniczakat);
            lbldgzakatcredit.Text = "Total Credit : " + Convert.ToString(totalzakatcredit);
            totallbldgzakatdebit.Text = "Total Debit :" + Convert.ToString(totalzakatDebit);
        }

        private void dtZakatDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnZakaterFetch_Click(object sender, EventArgs e)
        {
            FetchZakaterData();
        }

        private void txtZakaterSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtZakaterSearch.Text == "")
                AssignDefaultValues();
        }
        private void tsbClear_Click(object sender, EventArgs e)
        {
            AssignDefaultValues();
        }

        private void AssignDefaultValues()
        {
            txtZakaterName.Clear();
            txtZakaterNic.Clear();
            txtZakatAmount.Clear();
            cmbZakaterType.ResetText();
            rtZakaterAddress.Clear();
            rtZakatRemark.Clear();
            cmbZakaterType.Text="Bank Zakat";
        }
        private bool CoustomValidating()
        {
            int i = 0;

            if (string.IsNullOrWhiteSpace(cmbZakaterType.Text))
            {
                errorProviderZakat.SetError(cmbZakaterType, "please fill required field");
                i++;
            }
            if (string.IsNullOrWhiteSpace(txtZakatAmount.Text) || txtZakatAmount.Text == "0")
            {
                errorProviderZakat.SetError(txtZakatAmount, "please fill required field");
                i++;
            }
            if (i > 0)
            {
                return true;
            }
            return false;

        }
        private void FetchZakaterData()
        {
            try
            {
                zakatentry.ForEach(s =>
                {
                    if (s.ZakaterName == txtZakaterSearch.Text)
                    {
                        lblZakaterID.Text = Convert.ToString(s.Id);
                        txtZakaterName.Text = s.ZakaterName;
                        txtZakaterNic.Text = s.ZakaterNic;
                        rtZakaterAddress.Text = s.ZakaterAddress;

                    }
                });
            }
            catch (Exception)
            {
                MessageBox.Show("error while fetching");
            }
        }
        private void ZakaterTableData()
        {
            zakatentry.Clear();
            DataTable data = db.AllZakaters();
            if (data == null || data.Rows.Count == 0)
                return;

            for (int row = 0; row < data.Rows.Count; row++)
            {
                DataRow dataRow = data.Rows[row];
                ZakatModel z = new ZakatModel();
                z.Id = Convert.ToInt32(dataRow["ID"]);
                z.ZakaterName = Convert.ToString(dataRow["ZakaterName"]);
                z.ZakaterNic = Convert.ToString(dataRow["ZakaterNic"]);
                z.ZakaterAddress = Convert.ToString(dataRow["ZakaterAddress"]);
                zakatentry.Add(z);
            }

        }
        private void SearchZakaterNames()
        {
            var autoComplete = new AutoCompleteStringCollection();
            autoComplete.AddRange(zakatentry.AsEnumerable().Select(r => r.ZakaterName).ToArray());
            txtZakaterSearch.AutoCompleteCustomSource = autoComplete;
        }

        private void txtZakatAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnDashFilter_Click(object sender, EventArgs e)
        {
            GetCurrentMonthZakat(dtStartDate.Value);
        }

        private void btnZakatTransfer_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure", "", buttons: MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                db.TransferClinicZakatToBankZakat();
                GetCurrentMonthZakat(DateTime.Now.Date);

            }
            else
            {
                return;
            }

        }
    }
}
