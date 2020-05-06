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
            , DateTime wyborTerminu, decimal poleNetto, object poleStawkaVat, string EmployeeID)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlCommand sqlCmd = new SqlCommand("FakturaPopraw", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                sqlCmd.Parameters.AddWithValue("@idKlient", idKlient);
                sqlCmd.Parameters.AddWithValue("@adresKlient", "Adres będzie z tabeli klienci");
                sqlCmd.Parameters.AddWithValue("@dataWystawienia", DateTime.Now);
                sqlCmd.Parameters.AddWithValue("@formaPlatnosci", formaPlatnosci);
                sqlCmd.Parameters.AddWithValue("@imie", "marcin");
                sqlCmd.Parameters.AddWithValue("@naleznosci", Convert.ToDecimal(11.8));
                sqlCmd.Parameters.AddWithValue("@nazwaBanku", "mBank");
                sqlCmd.Parameters.AddWithValue("@nazwaFirmy", "TweakNet");
                sqlCmd.Parameters.AddWithValue("@nazwisko", "Marcin");
                sqlCmd.Parameters.AddWithValue("@nrFaktury", nrTejFaktury);
                sqlCmd.Parameters.AddWithValue("@telefon", "693");
                sqlCmd.Parameters.AddWithValue("@terminPlatnosci", wyborTerminu);
                sqlCmd.Parameters.AddWithValue("@brutto", Convert.ToDecimal(poleNetto));
                sqlCmd.Parameters.AddWithValue("@netto", Convert.ToDecimal(poleNetto));
                sqlCmd.Parameters.AddWithValue("@symbolVat", poleStawkaVat);
                sqlCmd.Parameters.AddWithValue("@vat", Convert.ToDecimal(1.258));
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