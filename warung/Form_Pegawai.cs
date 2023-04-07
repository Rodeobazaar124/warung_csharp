using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;

namespace warung
{
    public partial class Form_Pegawai : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=X230-MUHAMMAD-A\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=warung");
        string imglocation = "";
        public void hapus()
        {
            txt_id.Text = "";
            txt_nama.Text = "";
            txt_harga.Text = "";
            pictureBox1.ImageLocation = null;
            pictureBox1.Image = null;
            btnadd.Enabled = true;
            txt_id.ReadOnly = false;
            tampildata();

        }
        public void tampildata()
        {
            koneksi.Open();
            SqlCommand cmd = koneksi.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM MENU";

            DataTable dta = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dta);
            dataGridView1.DataSource = dta;
            koneksi.Close();
        }
        public Form_Pegawai()
        {
            InitializeComponent();
            tampildata();
        }
        private void Form_Pegawai_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.dataSet1.Menu);

        }

        private void cobalah_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(fs);
                images = brs.ReadBytes((int)fs.Length);

                koneksi.Open();
                
                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO MENU (IdMenu, Nama, Harga, Gambar) VALUES ('" + txt_id.Text + "', '" + txt_nama.Text + "', '" + txt_harga.Text + "', @images)";
                
                
                cmd.Parameters.Add(new SqlParameter("@images", images));
                
                cmd.ExecuteNonQuery();
                koneksi.Close();
                
                tampildata();
                hapus();
                MessageBox.Show("Menu baru berhasil dibuat");
            } catch (Exception ex)
            {
                MessageBox.Show("Error : '"+ex.Message+"'");
            }
        }

        private void btnimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imglocation;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                koneksi.Open();
                string suruh = "DELETE FROM [MENU] WHERE idmenu = '" + txt_id.Text + "' AND nama = '" + txt_nama.Text + "'";
                SqlCommand cmd = new SqlCommand(suruh, koneksi);
                cmd.ExecuteNonQuery();
                koneksi.Close();
                hapus();
                tampildata();
            } catch (Exception ex)
            {
                MessageBox.Show("Gagal Menghapus('"+ex.Message+"')");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txt_id.ReadOnly = true;
                txt_id.Text = row.Cells[0].Value.ToString();
                txt_nama.Text = row.Cells[1].Value.ToString();
                txt_harga.Text = row.Cells[2].Value.ToString();
                btnadd.Enabled = false;

                    MemoryStream ms = new MemoryStream((byte[])row.Cells[3].Value);
                    pictureBox1.Image = Image.FromStream(ms);
            } catch
            {
                hapus();
            }


        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] images = null;
                FileStream fs = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(fs);
                images = brs.ReadBytes((int)fs.Length);

                koneksi.Open();

                SqlCommand cmd = koneksi.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE MENU SET nama = '" + txt_nama.Text + "', Gambar = @images WHERE IdMenu = '" + txt_id.Text+"'";


                cmd.Parameters.Add(new SqlParameter("@images", images));

                cmd.ExecuteNonQuery();
                koneksi.Close();
                MessageBox.Show("Menu dengan id '" + txt_id.Text + "' berhasil diubah");

                hapus();

                tampildata();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message + "\n Silahkan tambahkan gambar jika belum ada, jika sudah ada silahkan laporkan error ini ke admin");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hapus();
        }
    }
}
