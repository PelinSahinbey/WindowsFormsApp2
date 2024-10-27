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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kul, sifre;
            kul = textBox1.Text;
            sifre = textBox2.Text;
            if (string.IsNullOrEmpty(kul))
            {
                MessageBox.Show("kullanıcı adı boş geçilemez", "Login hatası",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBox1.Focus();
            }
            if (string.IsNullOrEmpty(kul))
            {
                MessageBox.Show("şifre boş geçilemez", "Login hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
            }
            else
            {
                if(kul=="admin"&& sifre=="123")
                {
                    Form2 anasayfa = new Form2();
                    anasayfa.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("şifre hatalı", "Login hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
