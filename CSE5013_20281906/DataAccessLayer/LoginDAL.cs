using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using CSE5013_20281906.BusinessLogicLayer;

namespace CSE5013_20281906.DataAccessLayer
{
    class LoginDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public bool loginCheck(LoginBLL l)
        {
            bool issuccces = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "SELECT*FROM tbl_users WHERE username = @username AND password = @password AND user_type = @user_type";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);
                cmd.Parameters.AddWithValue("@id", l.id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //login successful
                    issuccces = true;
                }
                else
                {
                    issuccces = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return issuccces;
        }
    }
}
