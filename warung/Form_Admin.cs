using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace warung
{
    public partial class Form_Admin : Form
    {
        public Form_Admin()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            LaporanTransaksi lt1 = new LaporanTransaksi();
            lt1.Show();
            this.Hide();
        }


        private void kelolaAktifitasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form_Admin_Resize(object sender, EventArgs e)
        {

        }

        private void kelolaMenuMakananToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form_Admin_Load(object sender, EventArgs e)
        {

        }

        private void Form_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing) 
            {
                temp.catatlog(temp.user, "Logout");
                Application.Exit();
            }
        }

        private void btn_kelolauser_Click(object sender, EventArgs e)
        {
            KelolaPengguna kp1 = new KelolaPengguna();
            kp1.Show();
            this.Hide();
        }

        private void btn_kelolamenu_Click(object sender, EventArgs e)
        {
            KelolaMakanan fm = new KelolaMakanan();
            fm.Show();
            this.Hide();
        }

    }
}
