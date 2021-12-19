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
        }
        DBAccess db = new DBAccess();

        private void btnSave_Click(object sender, EventArgs e)
        {
            ZakatModel zakat = new ZakatModel();
            zakat.ZakaterName=txtZakaterName.Text;
            zakat.ZakaterNic = txtZakaterNic.Text;
            zakat.ZakaterAddress = rtZakaterAddress.Text;
            zakat.ZakatAmount=Convert.ToDouble( txtZakatAmount.Text);
            zakat.ZakaterType = cmbZakaterType.Text;
            zakat.ZakatDate =Convert.ToDateTime( dtZakatDate.Text);
            zakat.ZakatRemarks = rtZakatRemark.Text;
            db.AddZakat(zakat);

        }
    
        private void frm_ZakatInfo(object sender, EventArgs e)
        {
            DataTable dataTable = db.GetZakatInfo();
            if (dataTable == null || dataTable.Rows.Count == 0)
                return;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dgZakatList.Rows.Add();
                DataRow dataRow = dataTable.Rows[i];
                dgZakatList.Rows[i].Cells["ZakaterName"].Value =dataRow["ZakaterName"];
                dgZakatList.Rows[i].Cells["ZakatAmount"].Value = dataRow["ZakatAmount"];
                dgZakatList.Rows[i].Cells["ZakatRemarks"].Value = dataRow["ZakaterRemarks"];
                dgZakatList.Rows[i].Cells["ZakatDate"].Value = dataRow["ZakatDate"];
            }
        }

        private void dtZakatDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
