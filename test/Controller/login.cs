using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace test
{
    class login
    {
       public int ans = -1;
        public login(string username, string Password)
        {
            try { 
            db_connection k = new db_connection();
            string stm = "SELECT * from userlist where username='" + username + "'and password='"+Password+"'";
            ans = (int)k.Select(stm,1);
           }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public Object toString()
        {
            return ans;
        }
    }
}
