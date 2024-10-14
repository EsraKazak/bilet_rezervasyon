using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_rezervasyon
{
    internal class Firma : User
    {
        public string Ad { get; set; }
        public string Adres { get; set; }
        public string Tel { get; set; }
        public decimal Ucret { get; set; }


        string[,] sifre_kad = { { "A FİRMASI", "12345" }, { "B FİRMASI", "12345" }, { "C FİRMASI", "12345" }, { "D FİRMASI", "12345" }, { "F FİRMASI", "12345" } };
        public Firma(string ad, string adres, string tel, decimal ucret)
        {
            Ad = ad;
            Adres = adres;
            Tel = tel;
            Ucret = ucret;

        }

        ///////////////
        public string aracname { get; set; }
        public string firmaname { get; set; }
        public Sefer yol { get; set; }

        public Firma(string ad,string aracadı, Sefer guzergah)
        { 
            firmaname = ad;
            aracname = aracadı;
            yol = guzergah;
            
        }
        public Firma() { }

        public static List<Firma> a_firması = new List<Firma>();
        public static List<Firma> b_firması = new List<Firma>();
        public static List<Firma> c_firması = new List<Firma>();
        public static List<Firma> d_firması = new List<Firma>();
        public static List<Firma> f_firması = new List<Firma>();

        public static void aF()
        {
            // Sefer listesi oluşturun
            Sefer.seferlistesi();

            // Sefer nesneleri oluşturun ve firmaları ekleyin
            a_firması.Add(new Firma("A FİRMASI","OTOBÜS 1", Sefer.sefer_gönder(5)));
            a_firması.Add(new Firma("A FİRMASI", "OTOBÜS 1", Sefer.sefer_gönder(6)));
            a_firması.Add(new Firma("A FİRMASI", "OTOBÜS 2", Sefer.sefer_gönder(5)));
            a_firması.Add(new Firma("A FİRMASI", "OTOBÜS 2", Sefer.sefer_gönder(6)));

        }


        public static void bF()
        {
            // Sefer listesi oluşturun
            Sefer.seferlistesi();

            // Sefer nesneleri oluşturun ve firmaları ekleyin
            b_firması.Add(new Firma("B FİRMASI", "OTOBÜS 1", Sefer.sefer_gönder(5)));
            b_firması.Add(new Firma("B FİRMASI", "OTOBÜS 1", Sefer.sefer_gönder(6)));
            b_firması.Add(new Firma("B FİRMASI", "OTOBÜS 2", Sefer.sefer_gönder(7)));
            b_firması.Add(new Firma("B FİRMASI", "OTOBÜS 2", Sefer.sefer_gönder(8)));

        }
        public static void cF()
        {
            // Sefer listesi oluşturun
            Sefer.seferlistesi();

            // Sefer nesneleri oluşturun ve firmaları ekleyin
            c_firması.Add(new Firma("C FİRMASI", "OTOBÜS 1", Sefer.sefer_gönder(7)));
            c_firması.Add(new Firma("C FİRMASI", "OTOBÜS 1", Sefer.sefer_gönder(8)));
            c_firması.Add(new Firma("C FİRMASI", "UÇAK 1", Sefer.sefer_gönder(9)));
            c_firması.Add(new Firma("C FİRMASI", "UÇAK 1", Sefer.sefer_gönder(10)));
            c_firması.Add(new Firma("C FİRMASI", "UÇAK 2", Sefer.sefer_gönder(9)));
            c_firması.Add(new Firma("C FİRMASI", "UÇAK 2", Sefer.sefer_gönder(10)));

        }
        public static void dF()
        {
            // Sefer listesi oluşturun
            Sefer.seferlistesi();

            // Sefer nesneleri oluşturun ve firmaları ekleyin
            d_firması.Add(new Firma("D FİRMASI", "TREN 1", Sefer.sefer_gönder(1)));
            d_firması.Add(new Firma("D FİRMASI", "TREN 1", Sefer.sefer_gönder(2)));
            d_firması.Add(new Firma("D FİRMASI", "TREN 2", Sefer.sefer_gönder(3)));
            d_firması.Add(new Firma("D FİRMASI", "TREN 2", Sefer.sefer_gönder(4)));
            d_firması.Add(new Firma("D FİRMASI", "TREN 3", Sefer.sefer_gönder(3)));
            d_firması.Add(new Firma("D FİRMASI", "TREN 3", Sefer.sefer_gönder(4)));

        }
        public static void fF()
        {
            // Sefer listesi oluşturun
            Sefer.seferlistesi();

            // Sefer nesneleri oluşturun ve firmaları ekleyin
            f_firması.Add(new Firma("F FİRMASI", "UÇAK 1", Sefer.sefer_gönder(11)));
            f_firması.Add(new Firma("F FİRMASI", "UÇAK 1", Sefer.sefer_gönder(12)));
            f_firması.Add(new Firma("F FİRMASI", "UÇAK 2", Sefer.sefer_gönder(11)));
            f_firması.Add(new Firma("F FİRMASI", "UÇAK 2", Sefer.sefer_gönder(12)));

        }

        public override string ToString()
        {
            return $"{firmaname}  {aracname}  Güzergah --> {yol?.ToString()}";
        }

        public override bool Login(string username, string password)
        {
            // İki boyutlu dizideki satır sayısını alıyoruz
            int rows = sifre_kad.GetLength(0);

            // Satır sayısı kadar döngü oluşturuyoruz
            for (int i = 0; i < rows; i++)
            {
                // Kullanıcı adı ve şifreyi kontrol ediyoruz
                if (sifre_kad[i, 0] == username && sifre_kad[i, 1] == password)
                {
                    return true;
                }
            }

            return false;
        }


        public static List<Firma> UygunFirmalariBul(string gidisSeferi, string donusSeferi)
        {
            // Tüm firmaları bir listeye topla
            var tumFirmalar = a_firması.Concat(b_firması).Concat(c_firması).Concat(d_firması).Concat(f_firması).ToList();

            // Uygun firmaları depolamak için bir liste oluşturun
            List<Firma> uygunFirmalar = new List<Firma>();

            foreach (var firma in tumFirmalar)
            {
                var guzergah = firma.yol.Güzergah.Select(y => y.ToLower()).ToList();
                string gidisSeferiLower = gidisSeferi.ToLower();
                string donusSeferiLower = donusSeferi.ToLower();

                int gidisIndex = guzergah.IndexOf(gidisSeferiLower);
                int donusIndex = guzergah.IndexOf(donusSeferiLower);

                // Gidiş ve dönüş seferleri uygun mu ve doğru sıralama var mı kontrol et
                if (gidisIndex >= 0 && donusIndex >= 0 && gidisIndex < donusIndex)
                {
                    uygunFirmalar.Add(firma);
                }
            }

            return uygunFirmalar;
        }


    }

}
