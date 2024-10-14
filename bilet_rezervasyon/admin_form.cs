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
    public partial class admin_form : Form
    {
        public admin_form()
        {
            InitializeComponent();
        }

        private void admin_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin_islem admin = new admin_islem();
            bool b = true;
            Admin admn = new Admin();
            b = admn.Login(maskedTextBox1.Text, maskedTextBox2.Text);
            if (b)
            {
                admin.Show();
                this.Hide();
            }
            else { MessageBox.Show("Kullanıcı Adı veya Şifre Hatalıdır Kontrol Ediniz.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 ilkform= new Form1(); 
            ilkform.Show();
            this.Hide();
        }
    }
}
