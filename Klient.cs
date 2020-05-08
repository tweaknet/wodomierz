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
    public class Klient
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["wodomierz"].ConnectionString;

        public static void PoprawKlient(int idKlient, string imie, string nazwisko, string adres, string kodPocztowy, string nazwaFirmy, string telefon)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("PoprawKlient", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@idKlient", idKlient);
                sqlCmd.Parameters.AddWithValue("@imie", imie);
                sqlCmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                sqlCmd.Parameters.AddWithValue("@adres", adres);
                sqlCmd.Parameters.AddWithValue("@kodPocztowy", kodPocztowy);
                sqlCmd.Parameters.AddWithValue("@nazwaFirmy", nazwaFirmy);
                sqlCmd.Parameters.AddWithValue("@telefon", telefon);
                sqlCmd.ExecuteNonQuery();
                //PopulateDataGridView();
                //GridCennik();
            }
        }

        public static void InsertKlient(string imie, string nazwisko, string adres, string kodPocztowy, string nazwaFirmy, string telefon)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("DodajKlient", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@idKlient", tenidKlient);
                sqlCmd.Parameters.AddWithValue("@imie", imie);
                sqlCmd.Parameters.AddWithValue("@nazwisko", nazwisko);
                sqlCmd.Parameters.AddWithValue("@adres", adres);
                sqlCmd.Parameters.AddWithValue("@kodPocztowy", kodPocztowy);
                sqlCmd.Parameters.AddWithValue("@nazwaFirmy", nazwaFirmy);
                sqlCmd.Parameters.AddWithValue("@telefon", telefon);
                sqlCmd.ExecuteNonQuery();
                //PopulateDataGridView();
                //GridCennik();
            }
        }

        public static string tenidKlient;
        public static string NowyNrKlient()
        {
            try
            {
                using (SqlConnection polaczenie = new SqlConnection(connectionString))
                {
                    polaczenie.Open();
                    SqlCommand komendaSQL = polaczenie.CreateCommand();
                    komendaSQL.CommandText = "SELECT max(idKlient)+1 as idKlient FROM klient;";
                    SqlDataReader thisReader = komendaSQL.ExecuteReader();
                    while (thisReader.Read())
                    {
                        tenidKlient = thisReader["idKlient"].ToString();
                    }
                    thisReader.Close();
                    polaczenie.Close();
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
            return tenidKlient;
        }

        public int id { get; set; }
        public int idKlient { get; set; }
        public string imie { get; set; }
        public string nazwisko{ get; set; }
        public string adres { get; set; }
        public string kodPocztowy { get; set; }
        public string nazwaFirmy { get; set; }
        public string telefon { get; set; }


        public string FullInfo
        {
            get { return $"{imie} {nazwisko}"; }

        }

    }
}
