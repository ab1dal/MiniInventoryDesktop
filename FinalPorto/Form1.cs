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

namespace FinalPorto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string user = txtusername.Text;
            string pass = txtpassword.Text;
            MySqlConnection conn = new MySqlConnection("server=localhost;user id=root;database=db_loginpage");
            MySqlDataAdapter sda = new MySqlDataAdapter("select from login where username = '" + txtusername.Text + "' and password = '" + txtpassword.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
            else
            {
                MessageBox.Show("USERNAME ATAU PASSWORD SALAH");
            }
        }
    }
}
