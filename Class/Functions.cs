using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ShopManagementSystem.Class
{
    internal class Functions
    {
        public static SqlConnection Con;      

        public static void Connect()
        {
            Con = new SqlConnection();   //initialize object
            Con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\02.FPTU\05.Semester5\01.PRN211\PRN_Project\ShopManagementSystem\ShopManagement.mdf;Integrated Security=True;Connect Timeout=30";
            Con.Open();                     
            //check connection
            if (Con.State == ConnectionState.Open)
                MessageBox.Show("Connected!");
            else MessageBox.Show("Failed To Connect!");

        }
        public static void Disconnect()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close(); 
                Con.Dispose(); 	
                Con = null;
            }
        }

        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(); 
            dap.SelectCommand = new SqlCommand();
            dap.SelectCommand.Connection = Functions.Con; 
            dap.SelectCommand.CommandText = sql; 
            DataTable table = new DataTable();
            dap.Fill(table);
            return table;
        }

        public static bool CheckKey(string sql)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

        public static void RunSQL(string sql)
        {
            SqlCommand cmd; 
            cmd = new SqlCommand();
            cmd.Connection = Con; 
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.Con;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }

        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }

        public static void FillCombo(string sql, ComboBox cbo, string id, string name)
        {
            SqlDataAdapter dap = new SqlDataAdapter(sql, Con);
            DataTable table = new DataTable();
            dap.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = id;
            cbo.DisplayMember = name;

        }

        public static string GetFieldValues(string sql)
        {
            string id = "";
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();   
            while (reader.Read())
                id = reader.GetValue(0).ToString();
            reader.Close();
            return id;
        }

        public static string CreateKey()
        {
            string key = "";
            //split now date time
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('-');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], ConvertShortcutMonthToInt(partsDay[1]), partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }

        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }   

        public static string ConvertShortcutMonthToInt (string month)
        {
            string m = "";
            switch (month)
            {
                case "Jan":
                    m = "01";
                    break;
                case "Feb":
                    m = "02";
                    break;
                case "Mar":
                    m = "03";
                    break;
                case "Apr":
                    m = "04";
                    break;
                case "May":
                    m = "05";
                    break;
                case "Jun":
                    m = "06";
                    break;
                case "Jul":
                    m = "07";
                    break;
                case "Aug":
                    m = "08";
                    break;
                case "Sep":
                    m = "09";
                    break;
                case "Oct":
                    m = "10";
                    break;
                case "Nov":
                    m = "11";
                    break;
                case "Dec":
                    m = "12";
                    break;
            }
            return m;
        }
    }
}
