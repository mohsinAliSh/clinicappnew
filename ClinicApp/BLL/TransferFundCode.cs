using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicApp.BLL
{
    public partial class DBAccess
    {
        public void TransferFunds(int amount)
        {
            try {
                using (SqlConnection connection = new SqlConnection(GetConnection()))
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"spTransferFunds";
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    //  cmd.Connection = connection;
                    int resut = cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    MessageBox.Show("Transfer Successfull");
                }
            }
            catch(Exception)
            {
                MessageBox.Show("error");
            }
        }
        public void TransferFundsToClinic(int amount)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnection()))
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"spTransferBankToClinic";
                    cmd.Parameters.AddWithValue("@Amount", amount);
                    //   cmd.Connection = connection;
                    int resut = cmd.ExecuteNonQuery();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    MessageBox.Show("Transfer Successfull");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }

        }
    }
}
