using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                string conn = "datasource=localhost;database=login,form;port=3306;SSLMode=none;username=root;password=;";
                string query = "select * from login where Username =" + textBox1 + "'&& Password =" + textBox2;
                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, myConn);
                MySqlDataReader reader;
                myConn.Open();
                reader = cmd.ExecuteReader();
               
                if (reader.Read())
                {

                }

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {


                string conn = "datasource=localhost;database=login,form;port=3306;SSLMode=none;username=root;password=;";
                string query = "insert * from login where username =" + textBox1 + "'&& password =" + textBox2;
                MySqlConnection myConn = new MySqlConnection(conn);
                MySqlCommand cmd = new MySqlCommand(query, myConn);
                MySqlDataReader reader;
                myConn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
