using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Globalization;

namespace warung
{
    public partial class KelolaPengguna : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=X230-MUHAMMAD-A\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=warung");
        public KelolaPengguna()
        {
            InitializeComponent();
            if (temp.user == "Manajer")
            {
                backbtn.Enabled = false;
                backbtn.Visible = false;
            }
        }

        private void KelolaPengguna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pengguna.passwd' table. You can move, or remove it, as needed.
            this.passwdTableAdapter.Fill(this.pengguna.passwd);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;
                cmd.CommandText = @"UPDATE passwd SET password = '"+tb_newpassword.Text+"', role = '"+roleselector.Text+"' WHERE userid = '"+user_selector.Text+"'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil ganti password");
                this.passwdTableAdapter.Fill(this.pengguna.passwd);
                koneksi.Close();
            }
            catch {
                MessageBox.Show("Gagal!");                
            }
        }

        private void KelolaPengguna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                temp.catatlog(temp.user, "Logout");
                Application.Exit();
            }
        }


        private void btn_tambah_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;
                cmd.CommandText = @"INSERT INTO PASSWD VALUES ('"+user_selector.Text+"', '" + tb_newpassword.Text + "', '" + roleselector.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("User berhasil ditambahkan");
                this.passwdTableAdapter.Fill(this.pengguna.passwd);
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal:" + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dgvr = this.dataGridView1.Rows[e.RowIndex];
            user_selector.Text = dgvr.Cells[0].Value.ToString();
            tb_newpassword.Text = dgvr.Cells[1].Value.ToString();
            roleselector.Text = dgvr.Cells[2].Value.ToString();
            btn_tambah.Enabled = false;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            user_selector.Text = string.Empty;
            tb_newpassword.Text = string.Empty;
            roleselector.Text = string.Empty;
            this.passwdTableAdapter.Fill(this.pengguna.passwd);
            btn_tambah.Enabled = true;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = koneksi;
                cmd.CommandText = @"DELETE FROM passwd where password = '" + tb_newpassword.Text + "'AND role = '" + roleselector.Text + "' AND userid = '" + user_selector.Text + "'";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil hapus pengguna");
                this.passwdTableAdapter.Fill(this.pengguna.passwd);
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal:" + ex.Message);
            }    
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            if (temp.user == "Admin") {
                Form_Admin fa = new Form_Admin();
                fa.Show();
            }
        }
    }
}
