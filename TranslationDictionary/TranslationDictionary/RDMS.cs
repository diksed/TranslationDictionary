using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranslationDictionary
{
    public static class RDMS
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=[Enter the path to TranslationDictionaryDb.mdf here];Integrated Security=True";
        public static int SqlNonQuery(SqlCommand cmd)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    return cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static DataSet SqlReader(SqlCommand cmd)
        {
            try
            {
                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    cmd.Connection = conn;
                    var sda = new SqlDataAdapter(cmd);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    return ds;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
