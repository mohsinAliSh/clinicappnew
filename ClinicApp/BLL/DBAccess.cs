using ClinicApp.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.BLL
{
    public partial class DBAccess
    {

        static Settings settings = new Settings();

        public static SqlConnection connection = null;

        public bool CreateConnection()
        {
            try
            {
                connection = new SqlConnection(settings.DBString);
                connection.Open();
                return connection.State == System.Data.ConnectionState.Open ? true : false;

            }
            catch (Exception)
            {
                return false;
            }
        }

        public void CloseConnection()
        {
            try
            {
                if (connection == null)
                    return;

                connection.Close();
            }
            catch (Exception)
            {
                connection.Close();
            }
        }



        ~DBAccess()
        {
            if (connection != null)
                connection.Close();
        }

    }
}
