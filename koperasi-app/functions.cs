using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Web;

namespace koperasi_app
{
    public class functions
    {
        public static string connstr = @"server=localhost;userid=root;password=;database=dbkoperasi";
        public MySqlConnection conn = new MySqlConnection(connstr);
        public MySqlCommand cmd = new MySqlCommand();

        public string getIdForNewUser()
        {
            int id;
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tbluser ORDER BY id DESC", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    id = Convert.ToInt32(reader["id"]) + 1;
                }
                else
                {
                    id = 1;
                }
                return id.ToString();
            }
            catch { return "0"; }
            finally
            {
                conn.Close();
            }
        }

        public bool validate(string tblname, string key, string value)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM " + tblname + " WHERE " + key + " = '" + value + "' ",conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if ( reader.HasRows )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch { return false; }
            finally
            {
                conn.Close();
            }
        }

        public bool insertData(string tblname, string values)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO "+ tblname +" VALUES ("+ values +") ", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally
            {
                conn.Close();
            }
        }

        public bool deleteData(string tblname, string key, string value)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("DELETE FROM " + tblname + " WHERE " + key + " = " + value + " ",conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally
            {
                conn.Close();
            }
        }

        public string[] getUserInfo(string id)
        {
            string nama;
            string username;
            string password;
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tbluser WHERE id = "+ id +" ", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                nama = reader["nama"].ToString();
                username = reader["username"].ToString();
                password = reader["password"].ToString();

                string[] arr = new string[3];
                arr[0] = nama;
                arr[1] = username;
                arr[2] = password;

                return arr;
            }
            catch
            {
                string[] arr = new string[0];
                arr[0] = "0";

                return arr;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool updateData(string tblname, string data, string key, string value)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("UPDATE " + tblname + " SET " + data + "WHERE " + key + " = " + value + "", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally
            {
                conn.Close();
            }
        }
    }
}
