using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_rezervasyon
{
    public class Musteri
    {
        public string asoyad { get; set; }
        public string tc { get; set; }
        public string tarih { get; set; }
        public string telno { get; set; }

        // Statik bir liste oluşturuyoruz
        public static List<Musteri> Musters { get; set; } = new List<Musteri>();

        public Musteri(string ad_soyad, string tc, string dtarih, string tel)
        {
            this.asoyad = ad_soyad;
            this.tc = tc;
            this.tarih = dtarih;
            this.telno = tel;
        }

        public static void musteri_listesi(string ad_soyad, string tc, string dtarih, string tel)
        {
            Musters.Add(new Musteri(ad_soyad, tc, dtarih, tel));
        }

        // Müşterilerin bilgilerini döndüren bir metod
        public static string yolcu_bilgi()
        {
            StringBuilder bilgi = new StringBuilder();
            foreach (var m in Musters)
            {
                bilgi.AppendLine($"Ad Soyad: {m.asoyad}, TC: {m.tc}, Doğum Tarihi: {m.tarih}, Telefon Numarası: {m.telno}");
            }
            return bilgi.ToString();
        }
    }
}
