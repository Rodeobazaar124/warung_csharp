using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace warung
{
    class temp
    {

        //public static int id;
        public static string user;



        public static void catatlog (string user, string aktifitas){
        SqlConnection koneksi = new SqlConnection(@"Data Source=X230-MUHAMMAD-A\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=warung");
        if (koneksi.State.ToString() == "Open") {
            koneksi.Close();
        }
        koneksi.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO log VALUES('"+DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss")+"', '"+"["+user+"]  "+aktifitas+"')", koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
        }
    }

}
