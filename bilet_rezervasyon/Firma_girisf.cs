using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bilet_rezervasyon
{
    public partial class Firma_girisf : Form
    {
        public Firma_girisf()
        {
            InitializeComponent();
        }
        Firmaf firmaf = new Firmaf();

        private void button1_Click(object sender, EventArgs e)
        {

            Firma frma = new Firma();
            bool b = false;
            b = frma.Login(kullanıcıA_textbox.Text, maskedTextBox1.Text);
            if (b)
            {

                firmaf.labeltext(kullanıcıA_textbox.Text);
                firmaf.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("LÜTFEN BİLGİLERİNİZİ KONTROL EDİNİZ");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();  
            f.Show();
            this.Close();
        }
    }
}
