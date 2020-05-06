using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace wodomierz
{
    public class DataAccess
    {
        public List<Klient> GetKlients(string nazwisko)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("wodomierz")))
            {
                var output = connection.Query<Klient>($"select * from klient where nazwisko = '{nazwisko}' ").ToList();
                return output;
            }
        }
    }
}
