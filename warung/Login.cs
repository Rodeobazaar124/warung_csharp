using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace warung
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection koneksi = new SqlConnection(@"Data Source=X230-MUHAMMAD-A\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=warung");
            try
            {
                // Koneksikan dengan database
                koneksi.Open();

                // Jika Textbox belum diisi maka user akan diperingatkan
                if (userid.Text == "" && password.Text == "")
                {
                    MessageBox.Show("Masukkan kolom username dan password terlebih dahulu");
                }
                else
                {
                    // Menjalankan Query dengan parameter (query, sumberkoneksinya)
                    SqlDataAdapter SDA = new SqlDataAdapter("SELECT * FROM PASSWD WHERE userid ='" + userid.Text + "' AND password ='" + password.Text + "'", koneksi);

                    // Membuat variabel Tabel dan Mengisinya dengan Result dari SQL
                    DataTable dt = new DataTable();
                    SDA.Fill(dt);

                    // Jika didalam hasil Tabel ada, atau lebih dari satu maka dapatkan baris role dan dapatkan nilainya
                    // Jika cocok maka arahkan ke halaman sesuai role yang ditentukan
                    if (dt.Rows.Count > 0)
                    {
                        temp.user = userid.Text;
                        // Disini kalau aku lupa, dr itu ngambil value dari dt.Rows dan TipeData dia yaitu DataRow
                        foreach (DataRow dr in dt.Rows)
                        {

                            if (dr["role"].ToString() == "Admin")
                            {
                                this.Hide();

                                Form_Admin fa = new Form_Admin();
                                fa.Show();
                                temp.catatlog(temp.user, "Login");
                            }
                            else if (dr["role"].ToString() == "Pegawai")
                            {
                                this.Hide();
                                Form_Kasir fp = new Form_Kasir();
                                fp.Show();
                                temp.catatlog(temp.user, "Login");
                            }
                            else if (dr["role"].ToString() == "Manajer")
                            {
                                this.Hide();
                                KelolaMakanan f = new KelolaMakanan();
                                f.Show();
                                temp.catatlog(temp.user, "Login");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username atau Kata sandi anda salah! Silahkan hubungi admin!");
                    }
                }
                koneksi.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan \n ('" + ex.Message + "')");
                koneksi.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
