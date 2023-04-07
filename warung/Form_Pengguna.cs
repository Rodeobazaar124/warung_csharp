using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace warung
{
    public partial class Form_Pengguna : Form
    {
        SqlConnection koneksi = new SqlConnection(@"Data Source=X230-MUHAMMAD-A\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=warung");

        public Form_Pengguna()
        {
            InitializeComponent();
            if (tb_jumlah.Text == "")
            {
                tb_jumlah.Text = "1";
            }
        }
        private void Form_Pengguna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_Menu.Menu' table. You can move, or remove it, as needed.
            this.menuTableAdapter.Fill(this.dataSet_Menu.Menu);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                tb_idmenu.Text = row.Cells[0].Value.ToString();
                tb_namamenu.Text = row.Cells[1].Value.ToString();
                tb_harga.Text = row.Cells[2].Value.ToString();

                MemoryStream ms = new MemoryStream((byte[])row.Cells[3].Value);
                pictureBox1.Image = Image.FromStream(ms);
            }
            catch
            {
                MessageBox.Show("Error");
            }



        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            try
            {

                int totalHarga = int.Parse(tb_jumlah.Text) * int.Parse(tb_harga.Text);


                koneksi.Open();

                string q = "SELECT RIGHT(kode, 3) AS kode FROM transaksi WHERE kode = (SELECT MAX(kode) FROM transaksi)";
                SqlCommand comand = new SqlCommand(q, koneksi);
                object result = comand.ExecuteScalar();


                string lastdigit = result != null ? result.ToString() : "000"; // default to "000" if no rows found
                MessageBox.Show(lastdigit);
                int kodebaru = int.Parse(lastdigit) + 1;
                MessageBox.Show(kodebaru.ToString());
                string kode = DateTime.Now.ToString("yyyyMMdd") + kodebaru.ToString("D3");
                string perintah = "INSERT INTO transaksi (kode, id, nama, jumlah, tanggal, total_harga) values ('"+kode+"','" + tb_idmenu.Text + "', '" + tb_namamenu.Text + "', '" + tb_jumlah.Text + "', '" + DateTime.Now.ToString("yyyy - MM - dd HH: mm:ss.fff") + "', '" + totalHarga.ToString() + "')";
                SqlCommand cmd = new SqlCommand(perintah, koneksi);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Nomor : " + kode + "\nyaitu : "+ tb_namamenu.Text+"\nDengan Jumlah : " + tb_jumlah.Text + " \nDan Total harga : Rp." + totalHarga + "\n Berhasil dibuat!");
            }
            catch (Exception err)
            {
                MessageBox.Show("Gagal!" + "(" + err.Message + ")");
            }
        }
    }
}
