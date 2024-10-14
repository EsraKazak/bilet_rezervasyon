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
    public partial class biletbilgileri : Form
    {
        public biletbilgileri()
        {
            InitializeComponent();
        }

        private void biletbilgileri_Load(object sender, EventArgs e)
        {
            // Müşteri listesine eriş
            foreach (var musteri in Musteri.Musters)
            {
                // Her müşteri için bilgi formatını oluştur
                string bilgi = $"Ad Soyad: {musteri.asoyad}, TC: {musteri.tc}, Doğum Tarihi: {musteri.tarih}, Telefon Numarası: {musteri.telno}";
                listBox1.Items.Add(bilgi);
            }

        }
        public void AddTicketInfo(string ticketInfo)
        {
            listBox1.Items.Add(ticketInfo);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
