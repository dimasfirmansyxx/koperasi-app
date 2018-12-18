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
        public static string connstr = @"server=localhost;userid=root;password=;database=dbkoperasi;sslmode=none";
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

        public string getIdForNewMember()
        {
            int id;
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tblanggota ORDER BY id DESC", conn);
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
            }
            finally { conn.Close(); }
            return id.ToString();
        }

        public bool validate(string tblname, string key, string value)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM " + tblname + " WHERE " + key + " = '" + value + "' ", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public bool validateComplex(string query)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                conn.Close();
            }
        }

        public int numRows(string query)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                return num;
            }
            finally
            {
                conn.Close();
            }
        }

        public string monthID(string month)
        {
            int bln = Convert.ToInt32(month);
            string[] arr = new string[] { "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
            bln = bln - 1;
            return arr[bln];
        }

        public bool insertData(string tblname, string values)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("INSERT INTO " + tblname + " VALUES (" + values + ") ", conn);
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
                cmd = new MySqlCommand("DELETE FROM " + tblname + " WHERE " + key + " = '" + value + "' ", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
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
                cmd = new MySqlCommand("UPDATE " + tblname + " SET " + data + "WHERE " + key + " = '" + value + "'", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch { return false; }
            finally
            {
                conn.Close();
            }
        }

        public string getData(string tblname, string key, string value, string show)
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM " + tblname + " WHERE " + key + " = '" + value + "'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                return reader[show].ToString();
            }
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
                cmd = new MySqlCommand("SELECT * FROM tbluser WHERE id = " + id + " ", conn);
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
            finally
            {
                conn.Close();
            }
        }
        
        public string[] getRules()
        {
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tblaturan", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string[] arr = new string[7];
                arr[0] = reader["simpanan_pokok"].ToString();
                arr[1] = reader["simpanan_wajib"].ToString();
                arr[2] = reader["simpanan_sukarela"].ToString();
                arr[3] = reader["denda"].ToString();
                arr[4] = reader["maksimal_peminjaman"].ToString();
                arr[5] = reader["minimal_saldo"].ToString();
                arr[6] = reader["maks_root"].ToString();

                return arr;
            }
            finally
            {
                conn.Close();
            }
        }

        public string getIdMember(string tipe)
        {
            int code, jumlahPengurus, jumlahPendiri, jumlahKeduanya, jumlahMaksimal;
            string[] getMaxUser = getRules();
            string kode = "";
            MySqlCommand cmdPengurus, cmdPendiri = new MySqlCommand();
            jumlahMaksimal = Convert.ToInt32(getMaxUser[6]);

            if (tipe == "Pendiri" || tipe == "Pengurus")
            {
                try
                {
                    conn.Open();
                    cmdPengurus = new MySqlCommand("SELECT COUNT(*) FROM tblanggota WHERE lvl = 'PG'", conn);
                    cmdPendiri = new MySqlCommand("SELECT COUNT(*) FROM tblanggota WHERE lvl = 'P'", conn);
                    jumlahPengurus = Convert.ToInt32(cmdPengurus.ExecuteScalar());
                    jumlahPendiri = Convert.ToInt32(cmdPendiri.ExecuteScalar());
                    jumlahKeduanya = jumlahPengurus + jumlahPendiri;
                }
                finally
                {
                    conn.Close();
                }

                if (jumlahKeduanya > jumlahMaksimal)
                {
                    if (tipe == "Pengurus")
                        kode = "pengurus penuh";
                    else if (tipe == "Pendiri")
                        kode = "pendiri penuh";
                }
                else
                {
                    try
                    {
                        conn.Open();
                        cmd = new MySqlCommand("SELECT * FROM tblanggota WHERE lvl = 'P' OR lvl = 'PG' ORDER BY id DESC", conn);
                        MySqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            kode = reader["kode"].ToString();
                            kode = kode.Substring(0, 3);
                            code = Convert.ToInt32(kode) + 1;
                            if (tipe == "Pengurus")
                            {
                                if (code < 10)
                                    kode = "00" + code.ToString() + "PG";
                                else if (code < 100)
                                    kode = "0" + code.ToString() + "PG";
                                else
                                    kode = code.ToString() + "PG";
                            }
                            else if (tipe == "Pendiri")
                            {
                                if (code < 10)
                                    kode = "00" + code.ToString() + "P";
                                else if (code < 100)
                                    kode = "0" + code.ToString() + "P";
                                else
                                    kode = code.ToString() + "P";
                            }
                        }
                        else
                        {
                            if (tipe == "Pengurus")
                                kode = "001PG";
                            else if (tipe == "Pendiri")
                                kode = "001P";
                        }
                    }
                    finally { conn.Close(); }
                }
            }
            else if (tipe == "Anggota")
            {
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand("SELECT * FROM tblanggota WHERE lvl = 'A' ORDER BY id DESC", conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        kode = reader["kode"].ToString();
                        kode = kode.Substring(0, 3);
                        code = Convert.ToInt32(kode) + 1;
                        if (code < 10)
                            kode = "00" + code.ToString() + "PG";
                        else if (code < 100)
                            kode = "0" + code.ToString() + "PG";
                        else
                            kode = code.ToString() + "PG";
                    }
                    else
                    {
                        kode = "051A";
                    }
                }
                finally { conn.Close(); }
            }

            return kode;
        }

        public string[] getMemberInfo(string kode)
        {
            string[] arr = new string[5];
            try
            {
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tblanggota WHERE kode = '" + kode + "'", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if ( reader.HasRows )
                {
                    arr[0] = reader["nama"].ToString();
                    arr[1] = reader["alamat"].ToString();
                    arr[2] = reader["telepon"].ToString();
                    arr[3] = reader["ktp"].ToString();
                    arr[4] = reader["saldo"].ToString();
                }
                else
                {
                    arr[0] = "0";
                }
            }
            finally { conn.Close(); }
            return arr;
        }

        public string getDepositTransactionNumber()
        {
            try
            {
                int kode;
                conn.Open();
                cmd = new MySqlCommand("SELECT * FROM tblsimpanan ORDER BY id DESC", conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                    kode = Convert.ToInt32(reader["id"]) + 1;
                else
                    kode = 1000000001;

                return kode.ToString();
            }
            finally { conn.Close(); }
        }
    }
}
