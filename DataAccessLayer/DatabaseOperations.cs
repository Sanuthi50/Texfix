using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DatabaseOperations
    {
        SqlConnection con = new SqlConnection("Server =DESKTOP-FHJUDHK\\SQLEXPRESS; Database=Techfix; Trusted_Connection=True;");
        public int executeQuery(String sql)
        {
            try
            {
                SqlCommand com = new SqlCommand(sql, con);
                con.Open();
                return com.ExecuteNonQuery();

            }
            catch
            {
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        public DataSet selectQuery(String sql)
        {
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }
            catch
            {
                throw;

            }
            finally
            {
                con.Close();
            }
        }
    }
}
