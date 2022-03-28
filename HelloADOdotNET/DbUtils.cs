using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloADOdotNET
{
    public class DbUtils
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = "Server=localhost;Database=BookMan;User Id=sa;Password=123;";
            SqlConnection cnn = null;
            try
            {
                cnn = new SqlConnection(connectionString);

                cnn.Open();
                cnn.Close();
            }
            catch (Exception exc)
            {
                cnn = null;
                throw exc;
            }

            return cnn;
        }
    }
}
