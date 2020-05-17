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
    class StanWodomierza
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["wodomierz"].ConnectionString;

        public static void UpdateWodomierz(int id, string idKlient, string idWodomierz, string nrIdentyfikacyjny, string wskazanieWodomierza) 
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("PoprawWodomierz", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@id", id);
                sqlCmd.Parameters.AddWithValue("@idKlient", idKlient);
                sqlCmd.Parameters.AddWithValue("@idWodomierz", idWodomierz);
                sqlCmd.Parameters.AddWithValue("@nrIdentyfikacyjny", nrIdentyfikacyjny);
                sqlCmd.Parameters.AddWithValue("@wskazanieWodomierza", Convert.ToDecimal(wskazanieWodomierza));
                //sqlCmd.Parameters.AddWithValue("@dataOdczytu", dataOdczytu);
                sqlCmd.ExecuteNonQuery();
                //PopulateDataGridView();
                //GridCennik();
            }
        }

        public static void InsertWodomierz(string idKlient, int idWodomierz, string nrIdentyfikacyjny, string wskazanieWodomierza, string dataOdczytu)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("DodajWodomierz", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@idKlient", idKlient);
                sqlCmd.Parameters.AddWithValue("@idWodomierz", idWodomierz);
                sqlCmd.Parameters.AddWithValue("@nrIdentyfikacyjny", nrIdentyfikacyjny);
                sqlCmd.Parameters.AddWithValue("@wskazanieWodomierza", wskazanieWodomierza);
                sqlCmd.Parameters.AddWithValue("@dataOdczytu", Convert.ToDateTime(dataOdczytu));
                sqlCmd.ExecuteNonQuery();
                //PopulateDataGridView();
                //GridCennik();
            }
        }
        public static decimal tenwskazanieWodomierza;
        public static decimal OstatniOdczytWodomierza(int idKlient, int idWodomierz)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("OstatniOdczytWodomierza", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;

                    sqlCmd.Parameters.AddWithValue("@idKlient", idKlient);
                    sqlCmd.Parameters.AddWithValue("@idWodomierz", idWodomierz);

                    var returnParameter = sqlCmd.Parameters.Add("@ReturnVal", SqlDbType.Decimal);
                    returnParameter.Direction = ParameterDirection.Output;

                    sqlCmd.ExecuteNonQuery();
                    if (returnParameter.Value == DBNull.Value)
                    {
                    tenwskazanieWodomierza = -1;
                    }
                    else
                    {
                        decimal result = Convert.ToDecimal(returnParameter.Value);
                    tenwskazanieWodomierza = result;
                    }
                }
                return tenwskazanieWodomierza;
        }
    }
}
