using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 @ZakatAmount decimal,
@ZakatDate datetime,
@ZakaterRemarks varchar(200),
@ZakaterType varchar(50),
@ZakaterName varchar(200),
@ZakaterNic varchar(20),
@ZakaterAddress varchar(200),

*/

namespace ClinicApp.BLL
{
    public partial class DBAccess
    {
        public void AddZakat(Model.ZakatModel zakat)
        {
            try
            {
                if (!CreateConnection())
                    return;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"spAdd_Zakat";
                cmd.Parameters.AddWithValue("@ZakatAmount", zakat.ZakatAmount);
                cmd.Parameters.AddWithValue("@ZakatDate",zakat.ZakatDate);
                cmd.Parameters.AddWithValue("@ZakaterRemarks",zakat.ZakatRemarks);
                cmd.Parameters.AddWithValue("@ZakaterType", zakat.ZakaterType);
                cmd.Parameters.AddWithValue("@ZakaterName", zakat.ZakaterName);
                cmd.Parameters.AddWithValue("@ZakaterNic",zakat.ZakaterNic);
                cmd.Parameters.AddWithValue("@ZakaterAddress", zakat.ZakaterAddress);
                cmd.Connection = connection;
                int result = cmd.ExecuteNonQuery();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            }
            catch (Exception)
            {

            }
        }
    
        public DataTable GetZakatInfo()
        {
            DataTable dt = new DataTable();
            try
            {
                if (!CreateConnection())
                    return null;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.CommandText = @"spGet_Zakat";
                cmd.Connection = connection;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet set = new DataSet();
                sda.Fill(set);
                dt=set.Tables[0];
                CloseConnection();
                if (dt.Rows.Count == 0 || dt == null)
                    dt = null;
                return dt;


            }
            catch (Exception) {
                return null;
            }
        }
    }

}
