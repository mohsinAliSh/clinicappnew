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
        public void AddKets(int quantity)
        {
            try
            {
                using(SqlConnection connection = new SqlConnection(GetConnection()))
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"spAddKets";
                    cmd.Parameters.AddWithValue("@addKets", quantity);
                    int result = cmd.ExecuteNonQuery();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                }
                
                
          
            }

           catch (Exception e) {
                Console.WriteLine(e.Message);

            }
        }
        public String GetKetsData()

        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(GetConnection()))
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    connection.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = @"spGetKets";
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet dataSet = new DataSet();
                    da.Fill(dataSet);

                    table = dataSet.Tables[0];
                    int sum = 0;
                    if (table.Rows.Count == 0 || table == null)
                    {
                        table = null;
                        return "0";
                    }
                    else
                    {
                        for (int row = 0; row < table.Rows.Count; row++)
                        {


                            DataRow dataRow = table.Rows[row];
                            sum += Convert.ToInt32(dataRow["ketsQuantity"]);

                        }

                        return sum.ToString();
                    }
                }

                  
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
