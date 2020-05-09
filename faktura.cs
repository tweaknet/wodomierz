using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace wodomierz
{
    class Faktura
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["wodomierz"].ConnectionString;
        public static void UpdateFaktury(string idKlient, string formaPlatnosci, string nrTejFaktury
            , DateTime wyborTerminu, decimal poleNetto, object poleStawkaVat, string EmployeeID, string toImie, string lbAdresKlienta, string lbNazwaBanku
            , string tonazwisko, string nazwaFirmy, string telefon)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("FakturaPopraw", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@idKlient", idKlient);
                sqlCmd.Parameters.AddWithValue("@adresKlient", lbAdresKlienta);
                sqlCmd.Parameters.AddWithValue("@dataWystawienia", DateTime.Now);
                sqlCmd.Parameters.AddWithValue("@formaPlatnosci", formaPlatnosci);
                sqlCmd.Parameters.AddWithValue("@imie", toImie);
                sqlCmd.Parameters.AddWithValue("@naleznosci", Convert.ToDecimal(11.8));
                sqlCmd.Parameters.AddWithValue("@nazwaBanku", lbNazwaBanku);
                sqlCmd.Parameters.AddWithValue("@nazwaFirmy", nazwaFirmy);
                sqlCmd.Parameters.AddWithValue("@nazwisko", tonazwisko);
                sqlCmd.Parameters.AddWithValue("@nrFaktury", nrTejFaktury);
                sqlCmd.Parameters.AddWithValue("@telefon", telefon);
                sqlCmd.Parameters.AddWithValue("@terminPlatnosci", wyborTerminu);
                sqlCmd.Parameters.AddWithValue("@netto", Convert.ToDecimal(poleNetto));
                sqlCmd.Parameters.AddWithValue("@symbolVat", poleStawkaVat);
                sqlCmd.Parameters.AddWithValue("@idPrac", EmployeeID);
                sqlCmd.ExecuteNonQuery();
                //PopulateDataGridView();
                //GridCennik();
            }
        }
        public string nrNowejFaktury;
        public string PobierzNowyNrFaktury()
        {
            using (SqlConnection polaczenie = new SqlConnection(connectionString))
            {
                polaczenie.Open();
                SqlCommand komendaSQL = polaczenie.CreateCommand();
                komendaSQL.CommandText = "select max(right(nrFaktury,6)) as nrFaktury from faktura";
                SqlDataReader thisReader = komendaSQL.ExecuteReader();
                while (thisReader.Read())
                {
                    nrNowejFaktury = thisReader["nrFaktury"].ToString();
                }
                thisReader.Close();
                polaczenie.Close();
            }
            return Convert.ToString(Convert.ToInt32(nrNowejFaktury) + 1);
        }


    }
}