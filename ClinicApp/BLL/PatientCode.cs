using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using ClinicApp.Model;

namespace ClinicApp.BLL
{
    public partial class DBAccess
    {
        public DataTable GetAllPatients()
        {
            DataTable patientsTable = new DataTable();
            try
            {
                if (!CreateConnection())
                    return null;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"spGet_Patients";
                cmd.Connection = connection;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet dataSet = new DataSet();
                da.Fill(dataSet);
                patientsTable=dataSet.Tables[0];
                CloseConnection();
                if (patientsTable.Rows.Count == 0 || patientsTable == null)
                    return null;
                return patientsTable;
            }catch (Exception ex)
            {
                return null;
            }


        }

        public DataTable GetCurrentMonthPatients(DateTime month)
        {
            DataTable table = new DataTable();
            try
            {
                if (!CreateConnection())
                    return null;

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"sp_GetCurrentMonthPatient";
               // cmd.Parameters.AddWithValue("@month", month);
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


        public void AddPatientData(PatientModel patient,FeeEntryModel feeEntryModel)
        {
            try
            {
                
                if (!CreateConnection())
                    return;
       

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = @"sp_AddPatientRecord";
                cmd.Parameters.AddWithValue("@pID", patient.patientId);
                cmd.Parameters.AddWithValue("@pName", patient.pName);
                cmd.Parameters.AddWithValue("@pCnic", patient.pCnic);
                cmd.Parameters.AddWithValue("@pAddress", patient.pAddress);
                cmd.Parameters.AddWithValue("@pCity", patient.pCity);
                cmd.Parameters.AddWithValue("@pCountry", patient.pCountry);
                cmd.Parameters.AddWithValue("@pContact", patient.pContact);
                cmd.Parameters.AddWithValue("@pEConatct", patient.pEmergencyContact);
                cmd.Parameters.AddWithValue("@pGender", patient.pGender);
                cmd.Parameters.AddWithValue("@pMaritulStatus", patient.pMaritalStatus);
                cmd.Parameters.AddWithValue("@pEmail", patient.pEmail);
                cmd.Parameters.AddWithValue("@pDob", patient.pDob);
                cmd.Parameters.AddWithValue("@pActive", patient.pActive);
                cmd.Parameters.AddWithValue("@pDateCreated", patient.pCreatedDate);
                cmd.Parameters.AddWithValue("@pModifiedDate", patient.pModiefiedDate);
           //     cmd.Parameters.AddWithValue("@EntryDate", feeEntryModel.Date);
                cmd.Parameters.AddWithValue("@ClinicalFee", feeEntryModel.ClinicFee);
                cmd.Parameters.AddWithValue("@KetAmount", feeEntryModel.KetAmount);
                cmd.Parameters.AddWithValue("@DonationAmount", feeEntryModel.ZakatAmount);
                cmd.Parameters.AddWithValue("@NetFee", feeEntryModel.Total);
                cmd.Parameters.AddWithValue("@KetType", feeEntryModel.KetType);
                cmd.Parameters.AddWithValue("@PaymentType", feeEntryModel.FeeType);
                cmd.Connection = connection;
                int result = cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                MessageBox.Show("success"); 
            }
            catch (Exception ex) {
              Console.WriteLine(ex.Message);
                MessageBox.Show("error!");
                    }

        }
        //public void AddFeeEntry(FeeEntryModel feeEntryModel) {
        //    try {
        //        if (!CreateConnection())
        //            return;
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = @"spAddPatientFee";

        //        cmd.Connection = connection;
        //        int result = cmd.ExecuteNonQuery();
        //        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);

        //    }
        //    catch(Exception ex) { }
        //}

    }
}
