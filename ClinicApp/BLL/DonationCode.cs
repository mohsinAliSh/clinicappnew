using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicApp.BLL
{
    public partial class DBAccess
    {
        public void AddDonator(Model.DonatorEntryModel donator,Model.DonationEntryModel donation)
        {
            try
            {
                if (!CreateConnection())
                    return;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"sp_AddDonator";
                cmd.Parameters.AddWithValue("@dId",donator.DonatorID);
                cmd.Parameters.AddWithValue("@DonatorNic", donator.DonatorCnic);
                cmd.Parameters.AddWithValue("@DonatorName", donator.DonatorName);
                cmd.Parameters.AddWithValue("@DonatorAddress", donator.DonatorAddress);
                cmd.Parameters.AddWithValue("@DonationAmount", donation.DonationAmount);
                cmd.Parameters.AddWithValue("@DonatorType", donation.DonatorType);
                cmd.Parameters.AddWithValue("@DonationDate",donation.DonationDate);
                cmd.Parameters.AddWithValue("@DonationRemarks", donation.DonationRemarks);
                cmd.Connection = connection;
                int result = cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                MessageBox.Show("success");

            }
            catch (Exception) { }
        }
        public DataTable GetDonatorInfo()
        {
            DataTable table = new DataTable();
            try
            {
                if (!CreateConnection())
                    return null;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"spGetDonationInfo";
                cmd.Connection = connection;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                table = dataSet.Tables[0];
                CloseConnection();

                if (table.Rows.Count == 0 || table == null)
                    table = null;

                return table;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable AllDonators()
        {
            DataTable table = new DataTable();
            try
            {
                if (!CreateConnection())
                    return null;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"spGet_Donator";
                cmd.Connection = connection;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);

                table = dataSet.Tables[0];
                CloseConnection();

                if (table.Rows.Count == 0 || table == null)
                    table = null;

                return table;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public int TotalDonationAmount()
        {
            try
            {
                if (!CreateConnection())
                    return 0;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select SUM(DonationAmount) from DonationEntry";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                int count = (int)cmd.ExecuteScalar();
                SqlDataAdapter d = new SqlDataAdapter(cmd);
                CloseConnection();
                return count;

            }
            catch (Exception)
            {
                return 0;

            }

        }

    }
}
