using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pet_Management_System.Properties
{
    internal class Manage
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataAdapter da;
        public DataTable dt;


        public string serv = "server=localhost;uid=root;pwd=;database=db_exam1;";

        public void connect()
        {
            con = new MySqlConnection(serv);
            con.Open();
            MessageBox.Show("Connected");
            con.Close();
        }

        public DataTable display(string sql)
        {

            using (var conn = new MySqlConnection(serv))
            using (var da = new MySqlDataAdapter(sql, conn))
            {
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void display(string sql, DataGridView DG)
        {
            using (var con = new MySqlConnection(serv))
            using (var da = new MySqlDataAdapter(sql, con))
            {
                var dt = new DataTable();
                da.Fill(dt);
                DG.DataSource = dt;
            }

        }

        public void command(string sql)
        {
            using (var con = new MySqlConnection(serv))
            using (var cmd = new MySqlCommand(sql, con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }

        }

    }
}
