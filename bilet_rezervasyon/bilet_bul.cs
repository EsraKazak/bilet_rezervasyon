using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace bilet_rezervasyon
{
    public partial class bilet_bul : Form
    {
        public bilet_bul()
        {
            InitializeComponent();
        }
        koltuk_sec klt = new koltuk_sec();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string temp;
            temp = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bltbul();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button3.Enabled = listBox1.SelectedIndex != -1;
        }


        private void bltbul()
        {
            // TextBox'lardan gidiş ve dönüş sefer bilgilerini al
            string gidisSeferi = comboBox1.Text.Trim();
            string donusSeferi = comboBox2.Text.Trim();

            // Uygun firmaları bul
            List<Firma> uygunFirmalar = Firma.UygunFirmalariBul(gidisSeferi, donusSeferi);

            // Uygun firmaları ListBox'ta göster
            listBox1.Items.Clear();
            if (uygunFirmalar.Any())
            {
                foreach (var firma in uygunFirmalar)
                {
                    listBox1.Items.Add(firma.ToString());
                }
            }
            else
            {
                MessageBox.Show("uygun sefer ve firma bulunamadı");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {


            // ListBox'ta bir öğe seçili mi kontrol edelim
            if (listBox1.SelectedItem != null)
            {
                // Yeni Form2 nesnesi oluşturuyoruz


                // Form2'deki LabelText özelliğine, ListBox'taki seçili öğenin metnini atıyoruz
                klt.LabelText = listBox1.SelectedItem.ToString();
                klt.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("Lütfen bir öğe seçin.");

            }

        }

        private void bilet_bul_Load(object sender, EventArgs e)
        {
            button3.Enabled = false; // Butonu başlangıçta devre dışı bırakıyoruz
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 ilkform = new Form1();
            ilkform.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string temp;
            temp = comboBox1.SelectedItem?.ToString();
            if (temp == comboBox2.SelectedItem?.ToString())
            {
                MessageBox.Show("Bu öğe zaten seçildi, lütfen başka bir öğe seçin.");
                comboBox2.SelectedIndex = -1; // Seçimi iptal et
            }
        }
    }
}
