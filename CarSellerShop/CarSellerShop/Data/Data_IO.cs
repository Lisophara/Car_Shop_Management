using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarSellerShop.Data
{
    class Data_IO
    {
        #region -> Variable and Object

        string host = "localhost";
        string user = "root";
        string pass = "Leamlisophara1";
        string database = "carselling";

        MySqlConnection conn = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader reader;

        #endregion

        protected string connectionStr()
        {
            return $"Server={host};user id={user};password={pass};database={database}";
        }

        public bool Write_Data(string table, string dataToInsert)
        {

            try
            {
                conn.ConnectionString = connectionStr();
                conn.Open();
                cmd = new MySqlCommand($"INSERT INTO {table} VALUE ({dataToInsert})", conn);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show(mysqlEx.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public DataTable Read_Data(string col, string table, string joinStatement = "", string conditionStatement = "", string sort = "")
        {
            DataTable tb = new DataTable();
            try
            {
                conn.ConnectionString = connectionStr();
                conn.Open();
                cmd = new MySqlCommand($"SELECT {col} FROM {table} {joinStatement} {conditionStatement} {sort}", conn);
                reader = cmd.ExecuteReader();
                tb.Load(reader);
                reader.Close();
                conn.Close();
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show(mysqlEx.Message);
            }
            finally
            {
                conn.Close();
            }
            return tb;
        }

        public bool Update_Data(string table, string col_Value, string condition)
        {

            try
            {
                conn.ConnectionString = connectionStr();
                conn.Open();
                cmd = new MySqlCommand($"UPDATE `{table}` SET {col_Value} WHERE {condition}", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show(mysqlEx.Message);
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool Delete(string table,string primary, string primaryValue)
        {

            try
            {
                conn.ConnectionString = connectionStr();
                conn.Open();
                cmd = new MySqlCommand($"UPDATE {table} SET `is_deleted` = TRUE WHERE {primary} = {primaryValue}", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (MySqlException mysqlEx)
            {
                MessageBox.Show(mysqlEx.Message);
            }
            finally
            {
                conn.Close();
            }
            
            return false;
        }

        public string SaveImage(string src, string destination = "image")
        {
            try
            {
                string path = "";
                if (!Directory.Exists(destination))
                {
                    Directory.CreateDirectory(destination);
                }
                string[] splitTexts = src.Split('.');
                string extention = splitTexts[splitTexts.Length - 1];
                path = $@"{destination}/{Guid.NewGuid().ToString()}.{extention}";
                File.Copy(src, path);
                return path;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Image 404", "Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return "";
        }
    }
}
