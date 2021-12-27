using ClinicApp.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ClinicApp.BLL
{
    public partial class DBAccess
    {
        public DataTable GetExpenseData()
        {
            DataTable table = new DataTable();
            try
            {
                if (!CreateConnection())
                    return null;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"spGet_expanse";
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

        public void AddExpanse(Model.ExpenseEntryModel expanse)
        {
            try
            {
                if (!CreateConnection())
                    return;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"sp_AddExpense";
                cmd.Parameters.AddWithValue("@eCategory", expanse.expanseCatagory);
                cmd.Parameters.AddWithValue("@eDascription", expanse.expanseDiscription);
                cmd.Parameters.AddWithValue("@eAmount", expanse.expanseAmount);
                cmd.Parameters.AddWithValue("@eDate", expanse.expanseDate);
                cmd.Parameters.AddWithValue("@eExpenseFrom", expanse.expenseFrom);
                cmd.Connection = connection;
                int result = cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DialogResult rt = MessageBox.Show("Success", "",MessageBoxButtons.OK);
                if (rt == DialogResult.OK)
                {
                    Form1.formExpense.Dispose();
                    Form1.formExpense = new frmExpense();
                    Form1.formExpense.Show();
                }

            }
            catch (Exception) {
                MessageBox.Show("error");
            }

        }

    }
}