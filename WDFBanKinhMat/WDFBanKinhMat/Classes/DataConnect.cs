using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Form_1.Classes
{
    internal class DataConnect
    {
        ///strConB = Data Source=LAPTOP-6IJHPHQ6\SQLEXPRESS;Initial Catalog=WDFBanKinhMat_1;Integrated Security=True


        string strCon = "Data Source=LAPTOP-6IJHPHQ6\\SQLEXPRESS;Initial Catalog=WDFBanKinhMat_2;Integrated Security=True";
        SqlConnection sqlCon = null;

        private void OpenData()
        {
            sqlCon = new SqlConnection(strCon);
            if (sqlCon.State != System.Data.ConnectionState.Open)
            {
                sqlCon.Open();
            }
        }

        
        public DataTable ReadData(string str)
        {
            DataTable dt = new DataTable();
            OpenData();
            SqlDataAdapter sqlData = new SqlDataAdapter(str, sqlCon);
            sqlData.Fill(dt);
            sqlData.Dispose();
            CloseData();
            return dt;
        }

        public void ChangeData(string str)
        {
            OpenData();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlCon;
            cmd.CommandText = str;
            cmd.ExecuteNonQuery();
            CloseData();
            cmd.Dispose();

        }

        private void CloseData()
        {
            if (sqlCon.State != System.Data.ConnectionState.Closed)
            {
                sqlCon.Close();
                sqlCon.Dispose();
            }
        }

    }
}

