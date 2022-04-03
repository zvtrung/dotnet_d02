using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloADOdotNET
{
    public static class DbUtils
    {
        public static DbConnection GetConnection()
        {
            DbConnection cnn = null;

            #region Sử dụng với MySQL
            string myConnectionString = "server=127.0.0.1;uid=root;pwd=123;database=bookman";

            try
            {
                cnn = new MySql.Data.MySqlClient.MySqlConnection();
                cnn.ConnectionString = myConnectionString;
                cnn.Open();
                cnn.Close();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                cnn = null;
                //MessageBox.Show(ex.Message);
                throw ex;
            } 
            #endregion

            //#region Dùng với Ms SQL Server
            //string connectionString = "Server=localhost;Database=BookMan;User Id=sa;Password=123;";
            //try
            //{
            //    cnn = new SqlConnection(connectionString);

            //    cnn.Open();
            //    cnn.Close();
            //}
            //catch (Exception exc)
            //{
            //    cnn = null;
            //    throw exc;
            //} 
            //#endregion

            return cnn;
        }

        public static void CreateAndAddParam(DbCommand cmd, string ten, DbType kieuDuLieu, object value)
        {
            DbParameter p = cmd.CreateParameter();
            p.ParameterName = ten;
            p.DbType = kieuDuLieu;
            p.Value = value;
            cmd.Parameters.Add(p);
        }

    }
}
