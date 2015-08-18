using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
//
using System.ComponentModel;
using System.IO;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//

namespace test
{

    class db_connection : Exception
    {
        string _server = "", _userId = "", _password = "", _database = "";
        string _cs = "";
        MySqlCommand cmd = null;
        bool _connected = false;
        MySqlConnection conn = null;
        string _charset;
        //Empty Constractor - defualt param
        public db_connection()
        {
            _server = "localhost";
            //_server = "10.0.0.3";
          //  _server = "10.0.0.6";
            _userId = "root";
             _password = "";
            //_userId = "safali";
            //_password = "safali";
            _database = "safali";
            _charset = "utf8";
            _cs = "server=" + _server + ";userid=" + _userId + ";password=" + _password + ";database=" + _database + ";charset="+_charset+";";
            try
            {
                conn = new MySqlConnection(_cs);
            }
            //My sql error
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        //throw new Exception("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //throw new Exception("Invalid username/password, please try again");
                        break;
                }

            }
        }

        //Constractor with paran
        public db_connection(string server, string userid, string password, string database)
        {
            _server = server;
            _userId = userid;
            _password = password;
            _database = database;
            _cs = "server=" + _server + ";userid=" + _userId + ";password=" + _password + ";database=" + _database + "";
            try
            {
                conn = new MySqlConnection(_cs);
            }
            //My sql error
            catch { }
        }
        // the int reference what we are look for:
        //0 - means login only return a integer
        public int getUserId(String user)
        {
          
            string query = "select id from userlist where username='"+user+"';";
            int ans = -1;


            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = null;
                dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ans = Convert.ToInt32(dataReader["id"]);
                }

                //close Data Reader
                dataReader.Close();
                //return list to be displayed
                return ans;
            }
            catch
            {
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return -1;

        }
        
        public Object Select(string query, int j)
        {
            conn.Open();
            //Create a list to store the result
            if (j == 1)
            {
                int count = 0;
                try
                {
                    cmd = new MySqlCommand(query, conn);
                    MySqlDataReader dataReader = null;
                    dataReader = cmd.ExecuteReader();
                    while (dataReader.Read())
                    {
                        if (dataReader["administrator"].Equals("yes"))
                        {
                            count++;
                        }
                        count++;
                    }
                    dataReader.Close();
                    conn.Close();
                    return count;

                }
                catch { }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                List<string>[] list = new List<string>[3];
                list[0] = new List<string>();
                list[1] = new List<string>();
                list[2] = new List<String>();
                //Open connection
                if (this._connected == true && conn != null)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = null;

                    dataReader = cmd.ExecuteReader();
                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        list[0].Add(dataReader["username"] + "");
                        list[1].Add(dataReader["password"] + "");
                        list[2].Add(dataReader["id"] + "");
                    }

                    //close Data Reader
                    dataReader.Close();
                    //return list to be displayed
                    return list;
                }
                if (conn != null)
                {
                    conn.Close();
                }
                else
                {
                    return list;
                }

            }
            return "";
        }
        public string[] getUserData(string id)
        {
            string[] arr = new string[9];
            string query="select * from userDetails where id='"+id+"';";
            try
            {
                conn.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = null;

                dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    arr[0] = dataReader["id"] + "";
                    arr[1] = dataReader["idNumber"] + "";
                    arr[2] = dataReader["userName"] + "";
                    arr[3] = dataReader["userGender"] + "";
                    arr[4] = dataReader["userAge"] + "";
                    arr[5] = dataReader["userCity"] + "";
                    arr[6] = dataReader["userStreet"] + "";
                    arr[7] = dataReader["userHouseNumber"] + "";
                    arr[8] = dataReader["userCellPhone"] + "";

                }

                //close Data Reader
                dataReader.Close();
                //return list to be displayed
                return arr;
            }
            catch
            {
                return arr;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public List<string>[] SelectUser()
        {

            string query = "select * from userlist";
            List<string>[] list = new List<string>[5];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            list[4] = new List<string>();


            try
            {

                //Open connection
                conn.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = null;

                dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["username"] + "");
                    list[1].Add(dataReader["password"] + "");
                    list[2].Add(dataReader["id"] + "");
                    list[3].Add(dataReader["class"] + "");
                    list[4].Add(dataReader["homework"] + "");

                }

                //close Data Reader
                dataReader.Close();
                //return list to be displayed
                return list;
            }
            catch
            {
                return list;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public bool same_user(string username)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM userlist where username='" + username + "';";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
                conn.Close();
                if (count > 0)
                {
                    return true;
                }
            }
            catch
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return false;
        }
        public bool updateWordInClass(int userid, string wordid, int j)
        {
            string yesNo="No1";
            if (j == 1)
                yesNo = "Yes";
             try
            {
                string query =   "UPDATE class SET yesNO = '"+yesNo+"' WHERE wordid = '"+wordid+"' and userid='"+userid+"';";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                Int32 ans = -5;
                ans = Convert.ToInt32(cmd.ExecuteScalar());   
              if (ans != -5)
                {
                    return true;
                }
                }
                
            
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            return false;
        } 


        
        public bool insert_words_to_class(int clss,int wordId,int userId,int classNumber)
        {
            string cl="class";
            if (clss == 1)
            {
                cl = "homework";
            }
            try
            {
               
                string query = "INSERT INTO `class` (`class`, `wordId`, `userId`, `ClassNumber`, `yesNo`) VALUES ('" +cl+ "','" + wordId + "','" + userId + "','"+classNumber+"','No');";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                Int32 ans = -5;
                ans = Convert.ToInt32(cmd.ExecuteScalar());
               
                query = "UPDATE `safali`.`userlist` SET `"+cl+"` = '" + classNumber + "' WHERE `userlist`.`id` = " + userId + ";";
                conn.Close();
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                ans = -5;
                ans = Convert.ToInt32(cmd.ExecuteScalar());
                if (ans != -5)
                {
                    return true;
                }
                }
                
            
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            return false;
        } 


       // INSERT INTO `safali`.`userdetails` (`id`, `idNumber`, `userName`, `userGender`, `userAge`, `userCity`, `userStreet`, `userHouseNumber`, `userCellPhone`) VALUES ('2', 'ת.ז', 'שם', NULL, NULL, NULL, NULL, NULL, NULL);
        public bool inser_user_details(string id,string idNumber,string userName,string userGender,string userAge,string userCity,string userStreet,string userHouseNumber,string userCellPhone)
        {
            
            try
            {

                string query = "REPLACE INTO `userDetails` (`id`, `idNumber`, `userName`, `userGender`, `userAge`, `userCity`, `userStreet`, `userHouseNumber`, `userCellPhone`) VALUES ('" + id + "', '" + idNumber + "', '" + userName + "', '" + userGender + "', '" + userAge + "', '" + userCity + "', '" + userStreet + "', '"+userHouseNumber+"', '"+userCellPhone+"');";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                Int32 ans = -5;
                ans = Convert.ToInt32(cmd.ExecuteScalar());
                if (ans != -5)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine("**************************************************************");
                Debug.WriteLine(ex.ToString());
                Debug.WriteLine("**************************************************************");
                
                return false;
            }
            return false;
        
        }

            public bool insert_user(string username, string password, string admin)
        {
            try
            {
            
                string query = "INSERT INTO `userlist` (`username`, `password`, `administrator`) VALUES ('" + username + "','" + password + "','" + admin + "');";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                Int32 ans = -5;
                ans = Convert.ToInt32(cmd.ExecuteScalar());
                if (ans != -5)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            return false;
        }

        public bool remove_user(string username)
        {
            try
            {
                string query = "DELETE FROM userlist WHERE username='" + username + "';";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                Int32 ans = -5;
                ans = Convert.ToInt32(cmd.ExecuteScalar());
                if (ans != -5)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            return false;
        }

        public bool delword(string w)
        {
            try
            {
                string query = "DELETE FROM `dictionary` WHERE word='" + w + "';";
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                Int32 ans = -5;
                ans = Convert.ToInt32(cmd.ExecuteScalar());
                if (ans != -5)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            return false;
        }

        public string[] getWordData(string word1,PictureBox pb)
        {
            string[] arr = new string[24];
            string query="select * from dictionary where word='"+word1+"';";
            try
            {
                conn.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = null;

                dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    arr[0] = dataReader["id"] + "";
                    arr[1] = dataReader["word"] + "";
                    arr[2] = dataReader["syllable"] + "";
                    arr[3] = dataReader["openClose1"] + "";
                    arr[4] = dataReader["p_cut1"] + "";
                    arr[5] = dataReader["agaia1"] + "";
                    arr[6] = dataReader["koliut1"] + "";
                    arr[7] = dataReader["atama"] + "";
                    arr[8] = dataReader["diber"] + "";
                    arr[9] = dataReader["tzlil_place"] + "";
                    arr[10] = dataReader["pic"] + "";
                    arr[11] = dataReader["openClose2"] + "";
                    arr[12] = dataReader["openClose3"] + "";
                    arr[13] = dataReader["openClose4"] + "";
                    arr[14] = dataReader["p_cut2"] + "";
                    arr[15] = dataReader["p_cut3"] + "";
                    arr[16] = dataReader["p_cut4"] + "";
                    arr[17] = dataReader["agaia2"] + "";
                    arr[18] = dataReader["agaia3"] + "";
                    arr[19] = dataReader["agaia4"] + "";
                    arr[20] = dataReader["koliut2"] + "";
                    arr[21] = dataReader["koliut3"] + "";
                    arr[22] = dataReader["koliut4"] + "";
                    arr[23] = dataReader["noNikud"] + "";
                    byte[] imgg = (byte[])(dataReader["pic"]);
                    if (imgg == null)
                    {
                        pb.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pb.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }

                //close Data Reader
                dataReader.Close();
                //return list to be displayed
                return arr;
            }
            catch
            {
                return arr;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }
        public string[] getWordDataById(string id, PictureBox pb)
        {
            string[] arr = new string[24];
            string query = "select * from dictionary where id='" + id + "';";
            try
            {
                conn.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = null;

                dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {

                    arr[0] = dataReader["id"] + "";
                    arr[1] = dataReader["word"] + "";
                    arr[2] = dataReader["syllable"] + "";
                    arr[3] = dataReader["openClose1"] + "";
                    arr[4] = dataReader["p_cut1"] + "";
                    arr[5] = dataReader["agaia1"] + "";
                    arr[6] = dataReader["koliut1"] + "";
                    arr[7] = dataReader["atama"] + "";
                    arr[8] = dataReader["diber"] + "";
                    arr[9] = dataReader["tzlil_place"] + "";
                    arr[10] = dataReader["pic"] + "";
                    arr[11] = dataReader["openClose2"] + "";
                    arr[12] = dataReader["openClose3"] + "";
                    arr[13] = dataReader["openClose4"] + "";
                    arr[14] = dataReader["p_cut2"] + "";
                    arr[15] = dataReader["p_cut3"] + "";
                    arr[16] = dataReader["p_cut4"] + "";
                    arr[17] = dataReader["agaia2"] + "";
                    arr[18] = dataReader["agaia3"] + "";
                    arr[19] = dataReader["agaia4"] + "";
                    arr[20] = dataReader["koliut2"] + "";
                    arr[21] = dataReader["koliut3"] + "";
                    arr[22] = dataReader["koliut4"] + "";
                    arr[23] = dataReader["noNikud"] + "";
                    byte[] imgg = (byte[])(dataReader["pic"]);
                    if (imgg == null)
                    {
                        pb.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        pb.Image = System.Drawing.Image.FromStream(mstream);
                    }
                }

                //close Data Reader
                dataReader.Close();
                //return list to be displayed
                return arr;
            }
            catch
            {
                return arr;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

        }

        public List<string>[] Word()
        {

            string query = "select * from dictionary";
            List<string>[] list = new List<string>[10];
            list[0] = new List<string>();

            try
            {

                //Open connection
                conn.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = null;

                dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["word"] + "");
                }

                //close Data Reader
                dataReader.Close();
                //return list to be displayed
                return list;
            }
            catch
            {
                return list;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        public List<string>[] selectWord_withWhere(string where)
        {

            string query = "select * from dictionary" + where;
            List<string>[] list = new List<string>[10];
            list[0] = new List<string>();
            list[1] = new List<string>();

            try
            {

                //Open connection
                conn.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = null;

                dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["word"] + "");
                    list[1].Add(dataReader["id"] + "");
                }

                //close Data Reader
                dataReader.Close();
                //return list to be displayed
                return list;
            }
            catch
            {
                return list;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        
        ////////////////////////////////
        public bool insert_word(string word, string nos,sylOptionsClass h1,sylOptionsClass h2,sylOptionsClass h3,sylOptionsClass h4, string atama, string diber,string t_p,byte[] im,string nonikud)
        {
        //NOS = Number of Syl
            try
            {
               // string query = "INSERT INTO `dictionary` (`word`, `syllable`, `openClose`,`p_cut`,`agia`,`koliut`, `atama`,`diber`, `tzlil_place`) VALUES ('" + word + "','" + nos + "','" + oc + "','" + puc + "','" + agaia + "','" + koliut + "','" + atama + "','" + diber + "','" + t_p + "');";
                string query = "INSERT INTO `dictionary` (`word`,`syllable`,`openClose1`,`p_cut1`,`agaia1`,`koliut1`,`atama`,`diber`,`tzlil_place`,`pic`,`openClose2`, `openClose3`, `openClose4`, `p_cut2`, `p_cut3`, `p_cut4`, `agaia2`, `agaia3`, `agaia4`, `koliut2`, `koliut3`, `koliut4`, `noNikud`) VALUES ('" + word + "','" + nos + "','" + h1._openClose + "','" + h1._p_cut + "','" + h1._agia + "','" + h1._koliot + "','" + atama + "','" + diber + "','" + t_p + "',@IMG,'" + h2._openClose + "','" + h3._openClose + "','" + h4._openClose + "','" + h2._p_cut + "','" + h3._p_cut + "','" + h4._p_cut + "','" + h2._agia + "','" + h3._agia + "','" + h4._agia + "','" + h2._koliot + "','" + h3._koliot + "','" + h4._koliot + "','" + nonikud + "');";
                
                
                
                conn.Open();
                
                Int32 ans = -5;
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.Add(new MySqlParameter("@IMG", im));
                ans = Convert.ToInt32(cmd.ExecuteScalar());
                if (ans != -5)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
            return false;
        }

        public Image loadpicture(string s)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "select pic from dictionary where id='" + s + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            MySqlCommandBuilder cbd = new MySqlCommandBuilder(da);
            DataSet ds = new DataSet(); 
            da.Fill(ds,"Image");
            conn.Close();
            byte[] ap = (byte[])(ds.Tables[0].Rows[0]["pic"]);
            MemoryStream ms = new MemoryStream(ap);
            Image re = Image.FromStream(ms);
            ms.Close();
            return re;
        }
        public int getCurrentClass(int userId,int j) 
        {
            string cl = "class";
            if (j ==1)
            {
                cl = "homework";
            }
            string query = "select " + cl + " from userlist where id=" + userId + "";
            int ans = -1;


            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader = null;
                dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    ans = Convert.ToInt32(dataReader[cl]);
                }

                //close Data Reader
                dataReader.Close();
                //return list to be displayed
                return ans;
            }
            catch
            {
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            return -1;
        }
        public List<string>[] Selectgame(int userid,int classNumber,int homework)
        {
            string cl = "class";
            if (homework == 1)
                cl = "homework";

            string query = "SELECT `ClassNumber`,`wordId` FROM `class` WHERE userid='"+userid+"' and ClassNumber='"+classNumber+"' and class='"+cl+"' and yesNo='No';";
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();
           

            try
            {

                //Open connection
                conn.Open();
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, conn);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = null;

                dataReader = cmd.ExecuteReader();
                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["wordid"] + "");
                }

                //close Data Reader
                dataReader.Close();
                //return list to be displayed
                return list;
            }
            catch
            {
                return list;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

    }

}
