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
    public partial class historitransaksi : Form
    {
        public historitransaksi()
        {
            InitializeComponent();
        }

        private void historitransaksi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.transaksi' table. You can move, or remove it, as needed.
            this.transaksiTableAdapter.Fill(this.dataSet2.transaksi);

        }
    }
}
