using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bilet_rezervasyon
{
    public partial class Firmaf : Form
    {
        private Sefer sefer;

        public Firmaf()
        {

            InitializeComponent();
            Firma.aF(); // Firmaları listeye ekleyelim
            Firma.bF();
            Firma.cF();
            Firma.dF();
            Firma.fF();
            //LoadFirmalarToListBox(); // ListBox'a firmaları yükleyelim

        }




        private void Firmaf_Load(object sender, EventArgs e)
        {

        }


        public void labeltext(string text)
        {
            firmanamelabel.Text = text;
            LoadFirmalarToListBox();
        }
        private void LoadFirmalarToListBox()
        {


            // ListBox'ı temizleyelim (gerekliyse)
            listfirma.Items.Clear();

            switch (firmanamelabel.Text)
            {
                case "A FİRMASI":
                    {
                        // a_firması listesindeki firmaları ListBox'a ekleyelim
                        foreach (var firma in Firma.a_firması)
                        {
                            listfirma.Items.Add($"{firma.aracname} - {firma.yol}");
                        }

                    }
                    break;
                case "B FİRMASI":
                    {
                        // a_firması listesindeki firmaları ListBox'a ekleyelim
                        foreach (var firma in Firma.b_firması)
                        {
                            listfirma.Items.Add($"{firma.aracname} - {firma.yol}");
                        }

                    }
                    break;
                case "C FİRMASI":
                    {
                        // a_firması listesindeki firmaları ListBox'a ekleyelim
                        foreach (var firma in Firma.c_firması)
                        {
                            listfirma.Items.Add($"{firma.aracname} - {firma.yol}");
                        }

                    }
                    break;
                case "D FİRMASI":
                    {
                        // a_firması listesindeki firmaları ListBox'a ekleyelim
                        foreach (var firma in Firma.d_firması)
                        {
                            listfirma.Items.Add($"{firma.aracname} - {firma.yol}");
                        }

                    }
                    break;
                case "F FİRMASI":
                    {
                        // a_firması listesindeki firmaları ListBox'a ekleyelim
                        foreach (var firma in Firma.f_firması)
                        {
                            listfirma.Items.Add($"{firma.aracname} - {firma.yol}");
                        }

                    }
                    break;

            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listfirma_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // ekle butonu
        private void button1_Click(object sender, EventArgs e)
        {
            ekle();
        }
        private void ekle()
        {
            switch (firmanamelabel.Text)
            {
                case "A FİRMASI":
                    {
                        listfirma.Items.Add($"{textBox1.Text.ToUpper()} - {textBox2.Text.ToUpper()} --> {textBox3.Text.ToUpper()}");
                    }
                    break;
                case "B FİRMASI":
                    {

                        listfirma.Items.Add($"{textBox1.Text.ToUpper()} - {textBox2.Text.ToUpper()} --> {textBox3.Text.ToUpper()}");
                    }
                    break;
                case "C FİRMASI":
                    {
                        listfirma.Items.Add($"{textBox1.Text.ToUpper()} - {textBox2.Text.ToUpper()} --> {textBox3.Text.ToUpper()}");
                    }
                    break;
                case "D FİRMASI":
                    {
                        listfirma.Items.Add($"{textBox1.Text.ToUpper()} - {textBox2.Text.ToUpper()} --> {textBox3.Text.ToUpper()}");
                    }
                    break;
                case "F FİRMASI":
                    {
                        listfirma.Items.Add($"{textBox1.Text.ToUpper()} - {textBox2.Text.ToUpper()} --> {textBox3.Text.ToUpper()}");
                    }
                    break;

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void sil()
        {
            if (listfirma.SelectedItem != null)
            {
                // Seçili öğeyi kaldır
                listfirma.Items.Remove(listfirma.SelectedItem);
            }
            else
            {
                // Eğer hiçbir öğe seçili değilse, kullanıcıya bir mesaj gösterin
                MessageBox.Show("Lütfen silmek için bir öğe seçin.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listfirma.Items.Clear();
            Firma_girisf girs=new Firma_girisf();
            girs.Show();
            this.Hide();
               
        }
    }
}
