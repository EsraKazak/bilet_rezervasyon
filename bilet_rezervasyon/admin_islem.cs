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
    public partial class admin_islem : Form
    {
        private Admin admin;
        string ad;
        string adres;
        string tel;
        decimal ucret;

        public admin_islem()
        {
            InitializeComponent();
            admin = new Admin();
        }

        private void admin_islem_Load(object sender, EventArgs e)
        {
            if (admin != null)
            {
                UpdateListBox();
            }
        }

        private void UpdateListBox()
        {
            listfirma.Items.Clear();

            foreach (Firma firma in admin.Firmalar)
            {
                listfirma.Items.Add($"{firma.Ad} - {firma.Adres} - {firma.Tel} - {firma.Ucret:C}");
            }
        }


        private void sil_btn_Click(object sender, EventArgs e)
        {
            // Seçili öğeyi kontrol et
            if (listfirma.SelectedIndex != -1)
            {
                // Seçili öğeyi ListBox'tan al
                string selectedItemText = listfirma.SelectedItem.ToString();

                // Admin.Firmalar listesindeki ilgili Firma nesnesini bul
                Firma firmaToRemove = null;
                foreach (Firma firma in admin.Firmalar)
                {
                    if ($"{firma.Ad} - {firma.Adres} - {firma.Tel} - {firma.Ucret:C}" == selectedItemText)
                    {
                        firmaToRemove = firma;
                        break;
                    }
                }

                if (firmaToRemove != null)
                {
                    // Firma nesnesini Admin listesinden sil
                    admin.firmasil(firmaToRemove);

                    // ListBox'tan da öğeyi kaldır
                    listfirma.Items.Remove(selectedItemText);
                }
            }
            else
            {
                MessageBox.Show("Silinecek bir firma seçin.");
            }
        }


        private void EKLE_BTN_Click(object sender, EventArgs e)
        {
            ad = txtFirmaAdi.Text;
            adres = txtAdres.Text;
            tel = txtTel.Text;
            if (!decimal.TryParse(txtUcret.Text, out ucret))
            {
                MessageBox.Show("Geçerli bir ücret girin.");
                return; // Hatalı giriş varsa işleme devam etme
            }
            // Firma nesnesi oluştur
            Firma yeniFirma = new Firma(ad, adres, tel, ucret);

            // Admin listesini güncelle
            admin.FirmaEkle(yeniFirma);

            // Form üzerindeki ListBox'ı güncellemek isterseniz:
            listfirma.Items.Add($"{yeniFirma.Ad} - {yeniFirma.Adres} - {yeniFirma.Tel} - {yeniFirma.Ucret:C}");


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listfirma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 ilkform = new Form1();
            ilkform.Show();
            this.Close();
        }
    }
}
