using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class UserBLL
    {
                public int id { get; set; }
                public string name { get; set; }
                public string email { get; set; }
                public string username { get; set; }
                public string password { get; set; }
                public string contact { get; set; }
                public string address { get; set; }
                public string user_type { get; set; }
                public DateTime added_date { get; set; }
                public int added_by { get; set; }

        public int insert()
        {
            String sql = 
            try
            {
                return new DatabaseOperations().executeQuery(sql);

            }
            catch
            {
                throw;

            }
        }
        public int update()
        {
            String sql = "UPDATE supplier SET name= '" + name + "', email ='" + email + "', phone = '" + phone + "',address ='" + address + "' WHERE id =" + id;
            try
            {
                return new DatabaseOperations().executeQuery(sql);

            }
            catch
            {
                throw;

            }
        }
        public int delete()
        {
            String sql = "DELETE FROM supplier WHERE id =" + id;
            try
            {
                return new DatabaseOperations().executeQuery(sql);

            }
            catch
            {
                throw;

            }
        }
        public DataSet find()
        {
            try
            {
                String sql = "SELECT *FROM supplier WHERE id =" + id;
                DataSet ds = new DatabaseOperations().selectQuery(sql);

                return ds;




            }

            catch
            {
                throw;
            }

        }

        public DataSet viewAll()
        {
            try
            {
                string sql = "SELECT*FROM supplier";
                return new DatabaseOperations().selectQuery(sql);

            }
            catch
            {
                throw;
            }
        }
    }
}
