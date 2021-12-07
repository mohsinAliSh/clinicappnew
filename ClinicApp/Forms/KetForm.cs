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
        int sum = 0;
        public void LoadKetsQuantity(object sender, EventArgs e)
        {
            sum = 0;
            DataTable dt = dBAccess.GetKetsData();

            if (dt == null || dt.Rows.Count == 0)
                return;



            for (int row = 0; row < dt.Rows.Count; row++)
            {

                
                DataRow dataRow = dt.Rows[row];
                sum += Convert.ToInt32(dataRow["NewKits"]);
               
            }
            totalKetsLabel.Text=sum.ToString();
            Form1 f1 = new Form1();
            

        }

        private void KetsAddButton_Click(object sender, EventArgs e)
        {
            dBAccess.AddKets(Convert.ToInt32(NewKetsLabel.Text));
            NewKetsLabel.Clear();
            LoadKetsQuantity(sender,e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }
     
    }
}
