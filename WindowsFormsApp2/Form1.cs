using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connetionString = "server=localhost;user=root;datebase=auth;";
            
            
            string connectionString = "server=localhost;user=root;database=sport;";
            MySqlConnection con;
            
            con = new MySqlConnection(connectionString);
            con.Open();
            MySqlDataAdapter da = new MySqlDataAdapter("select * from sport.вид_спорта", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            BindingSource bs = new BindingSource(ds, ds.Tables[0].TableName);
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;
            con.Close();
        }
    }
}
