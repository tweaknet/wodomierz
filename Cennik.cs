using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wodomierz
{
    
    class Cennik
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["wodomierz"].ConnectionString;

        public static void PoprawCennik(int id, DateTime dataOd, DateTime dataDo, decimal netto, int symbolVat)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("PoprawCennik", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@id", id);
                sqlCmd.Parameters.AddWithValue("@dataOd", dataOd.Date);
                sqlCmd.Parameters.AddWithValue("@dataDo", dataDo.Date);
                sqlCmd.Parameters.AddWithValue("@netto", netto);
                sqlCmd.Parameters.AddWithValue("@symbolVat", symbolVat);
                sqlCmd.ExecuteNonQuery();
            }
        }
        public static void DodajCennik(DateTime dataOd, DateTime dataDo, decimal netto, int symbolVat)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("DodajCennik", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@dataOd", dataOd.Date);
                sqlCmd.Parameters.AddWithValue("@dataDo", dataDo.Date);
                sqlCmd.Parameters.AddWithValue("@netto", netto);
                sqlCmd.Parameters.AddWithValue("@symbolVat", symbolVat);
                sqlCmd.ExecuteNonQuery();
            }
        }
        public static void UsunCennik(int id)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlCmd = new SqlCommand("usunCennik", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@id", id);
                        sqlCmd.ExecuteNonQuery();
                    }
                
        }


    }
}
