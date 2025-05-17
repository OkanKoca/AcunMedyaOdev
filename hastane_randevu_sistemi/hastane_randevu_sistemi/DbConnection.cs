using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace hastane_randevu_sistemi
{
    public static class DbConnection
    {
        static readonly string connectionString = "Server=DESKTOP-KROK7IU\\SQLEXPRESS01;Database=hastane_randevu_sistemi;Trusted_Connection=True;";

        public static SqlConnection VeritabaninaBaglan()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return connection;
                }
                catch (Exception ex) {
                    throw new Exception("Veritabanı bağlantısı başarısız" + ex.Message);
                }
               
            }
        }

    }
}
