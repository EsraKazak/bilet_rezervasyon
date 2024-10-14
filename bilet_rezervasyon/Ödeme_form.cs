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
    public partial class Ödeme_form : Form
    {
        public Ödeme_form(int koltukNo)
        {
            InitializeComponent();
            label5.Text = $"Koltuk No: {koltukNo}";
        }


        private void Ödeme_form_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
    maskedTextBox1.MaskFull &&
    maskedTextBox3.MaskFull)
            {
                Musteri.musteri_listesi(textBox1.Text, maskedTextBox1.Text, dateTimePicker1.Text, maskedTextBox3.Text);
                // Gerekli bilgiler doldurulduktan sonra formu kapatın
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen Eksik Bilgileri Doldurunuz");
            }

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
