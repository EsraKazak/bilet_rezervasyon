using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

namespace bilet_rezervasyon
{
    public class Sefer
    {
        public List<string> Güzergah { get; set; }

        public Sefer(List<string> güzergah)
        {
            Güzergah = güzergah;
        }

        public Sefer() { }

        public static List<Sefer> sefers = new List<Sefer>();

        public static void seferlistesi()
        {
            sefers.Add(new Sefer(new List<string> { "istanbul", "kocaeli", "bilecik", "eskişehir", "ankara"}));
            sefers.Add(new Sefer(new List<string> { "ankara", "eskişehir", "bilecik", "kocaeli", "istanbul" }));
            sefers.Add(new Sefer(new List<string> { "istanbul", "kocaeli", "bilecik", "eskişehir", "konya"}));
            sefers.Add(new Sefer(new List<string> { "konya", "eskişehir", "bilecik", "kocaeli", "istanbul" }));
            sefers.Add(new Sefer(new List<string> { "istanbul", "kocaeli", "ankara"}));
            sefers.Add(new Sefer(new List<string> { "ankara", "kocaeli", "istanbul" }));
            sefers.Add(new Sefer(new List<string> { "istanbul", "kocaeli", "eskişehir", "konya"}));
            sefers.Add(new Sefer(new List<string> { "konya", "eskişehir", "kocaeli", "istanbul" }));
            sefers.Add(new Sefer(new List<string> { "istanbul", "konya"}));
            sefers.Add(new Sefer(new List<string> { "konya", "istanbul" }));
            sefers.Add(new Sefer(new List<string> { "istanbul", "ankara"}));
            sefers.Add(new Sefer(new List<string> { "ankara", "istanbul" }));
        }

        public static Sefer sefer_gönder(int seferno)
        {
            if (seferno >= 1 && seferno <= sefers.Count)
            {
                return sefers[seferno - 1];
            }
            return null;
        }

        public override string ToString()
        {
            return string.Join(" -> ", Güzergah);
        }
    }
}
