using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;



namespace ClinicApp.BLL
{
    public partial class DBAccess
    {
        public void AddDonation(Model.DonationEntryModel donation)
        {
            try
            {
                if (!CreateConnection())
                    return;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"sp_AddDonation";
                //    cmd.Parameters.AddWithValue("@dID",donation.);
                cmd.Parameters.AddWithValue("@DonatorNic", donation.DonatorCnic);
                cmd.Parameters.AddWithValue("@DonatorName", donation.DonatorName);
                cmd.Parameters.AddWithValue("@DonatorAddress", donation.DonatorAddress);
                cmd.Parameters.AddWithValue("DonatorDate", DateTime.Now);
                cmd.Connection = connection;
                int result = cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

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
                cmd.CommandText = @"spGetDonatorInfo";
                //cmd.Parameters.AddWithValue("@month", month);
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
    }
}
