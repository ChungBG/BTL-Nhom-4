using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Windows;

namespace BTLCK_n1
{
    class ThucthiSQL
    {
        public static SqlConnection con = new SqlConnection();

        public static string connectionString = "Data Source=DESKTOP-NAN437V\\SQLEXPRESS;Initial Catalog=QUANLYBANHANGSIEUTHI1;Integrated Security=True";
        public static void KetNoiCSDL()
        {
            con = new SqlConnection();
            con.ConnectionString = connectionString;
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public static void DongKetNoiCSDL()
        {
            if (con.State != ConnectionState.Closed)
            {
                con.Close();
                con.Dispose();
                con = null;
            }

        }
        public static DataTable DocBang(string sql)
        {

            DataTable dt = new DataTable();
            SqlDataAdapter Mydata = new SqlDataAdapter();
            Mydata.SelectCommand = new SqlCommand();
            KetNoiCSDL();
            Mydata.SelectCommand.Connection = con;
            Mydata.SelectCommand.CommandText = sql;
            Mydata.Fill(dt);
            DongKetNoiCSDL();
            return dt;

        }
        public static void CapNhatDuLieu(string sql)
        {
            KetNoiCSDL();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = con;
            sqlCommand.CommandText = sql;
            sqlCommand.ExecuteNonQuery();
            DongKetNoiCSDL();
        }
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }
    }
}


