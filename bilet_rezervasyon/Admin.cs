using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilet_rezervasyon
{
    internal class Admin : User
    {
        string[,] sifre_kad = { { "11111", "12345" }, {"22222","12345" } };

        public List<Firma> Firmalar { get; private set; }

        public Admin()
        {
            Firmalar = new List<Firma>
        {
            new Firma("Firma A", "Adres A","1111111111",100),
            new Firma("Firma B", "Adres B","2222222222", 200),
            new Firma("Firma C", "Adres C", "3333333333", 300)
        };
        }

        public void FirmaEkle(Firma firma)
        {
            Firmalar.Add(firma);
        }

        public void  firmasil(Firma firma )
        {
            Firmalar.Remove(firma);
        }
        public override bool Login(string username, string password)
        {
            if(username == sifre_kad[0,0] && password== sifre_kad[0,1]) return true;
            else return false;
            
        }

    }
}
