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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;database=db_loginpage";
            string query = "INSERT INTO data_penyewa(nama,no_hp,tujuan,lama_sewa,tanggal_sewa) VALUES ('" + this.nama.Text + "', '" + this.no_hp.Text + "', '" + this.tujuan.Text + "', '" + this.lama.Text + "', '" + this.tanggal.Text + "')";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("BERHASIL MEMASUKKAN DATA");
            conn.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;database=db_loginpage";
            string query = "DELETE FROM data_penyewa where nama='" + this.nama.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("BERHASIL MENGHAPUS DATA");
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;database=db_loginpage";
            string query = "UPDATE data_penyewa SET nama='" + this.nama.Text + "', no_hp='" + this.no_hp.Text + "', tujuan='" + this.tujuan.Text + "', lama='" + this.lama.Text + "', tanggal ='" + this.tanggal.Text + "'";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader dr;
            conn.Open();
            dr = cmd.ExecuteReader();
            MessageBox.Show("UPDATE BERHASIL");
            conn.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string connection = "server=localhost;user id=root;database=db_loginpage";
            string query = "SELECT * FROM data_penyewa";
            MySqlConnection conn = new MySqlConnection(connection);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataAdapter da = new MySqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
    }
}

