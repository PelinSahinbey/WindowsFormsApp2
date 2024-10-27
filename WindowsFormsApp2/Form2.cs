using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 musteri = new Form3();
            musteri.MdiParent = this;
            musteri.Show();
        }
       

        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form4 stok = new Form4();
            stok.MdiParent = this;
            stok.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("uygulamadan çıkmak istiyor musunuz?", "uygulama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
            Application.Exit();
        }
    }

}
