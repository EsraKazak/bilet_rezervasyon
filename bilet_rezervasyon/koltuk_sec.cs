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
    public partial class koltuk_sec : Form
    {
        private List<CheckBox> checkBoxes = new List<CheckBox>();
        private List<string> purchasedTickets = new List<string>(); // Alınan biletlerin bilgilerini saklamak için liste
        public koltuk_sec()
        {
            InitializeComponent();
            InitializeCheckBoxes();
            RandomizeCheckBoxes();
            checkboxbloke(); // İşaretli olan CheckBox'ları devre dışı bırak

        }


        private void InitializeCheckBoxes()
        {
            // CheckBox'ları form üzerindeki isimlere göre listeye ekleyin.
            checkBoxes.Add(checkBox1);
            checkBoxes.Add(checkBox2);
            checkBoxes.Add(checkBox3);
            checkBoxes.Add(checkBox4);
            checkBoxes.Add(checkBox5);
            checkBoxes.Add(checkBox6);
            checkBoxes.Add(checkBox7);
            checkBoxes.Add(checkBox8);
            checkBoxes.Add(checkBox9);
            checkBoxes.Add(checkBox10);
            checkBoxes.Add(checkBox11);
            checkBoxes.Add(checkBox12);
            checkBoxes.Add(checkBox13);
            checkBoxes.Add(checkBox14);
            checkBoxes.Add(checkBox15);
            checkBoxes.Add(checkBox16);
            checkBoxes.Add(checkBox17);
            checkBoxes.Add(checkBox18);
            checkBoxes.Add(checkBox19);
            checkBoxes.Add(checkBox20);
            checkBoxes.Add(checkBox21);
            checkBoxes.Add(checkBox22);
            checkBoxes.Add(checkBox23);
            checkBoxes.Add(checkBox24);
            checkBoxes.Add(checkBox25);
            checkBoxes.Add(checkBox26);
            checkBoxes.Add(checkBox27);
            checkBoxes.Add(checkBox28);
            checkBoxes.Add(checkBox29);
            checkBoxes.Add(checkBox30);
            checkBoxes.Add(checkBox31);
            checkBoxes.Add(checkBox32);
            // Devam edin tüm CheckBox'lar için
            // CheckBox'ları form üzerindeki isimlere göre listeye ekleyin.
            for (int i = 1; i <= 32; i++)
            {
                CheckBox cb = this.Controls["checkBox" + i] as CheckBox;
                if (cb != null)
                {
                    checkBoxes.Add(cb);

                }
            }
        }

        private void checkboxbloke()
        {
            foreach (var checkBox in checkBoxes)
            {
                if (checkBox.Checked)
                {
                    checkBox.Enabled = false; // İşaretli olan CheckBox'ları devre dışı bırak
                }
            }
        }

        private void RandomizeCheckBoxes()
        {
            Random random = new Random();
            foreach (var checkBox in checkBoxes)
            {
                checkBox.Checked = random.Next(2) == 0; // %50 şansla işaretle
            }
        }
        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedSeatsCount = checkBoxes.Count(cb => cb.Checked);

            if (selectedSeatsCount == 0)
            {
                MessageBox.Show("Lütfen en az bir koltuk seçin.");
                return;
            }

            for (int i = 0; i < selectedSeatsCount; i++)
            {
                // İşaretli olan koltukları bulun
                CheckBox selectedCheckBox = checkBoxes.FirstOrDefault(cb => cb.Checked && cb.Enabled);

                if (selectedCheckBox != null)
                {
                    int koltukNo = int.Parse(selectedCheckBox.Name.Replace("checkBox", ""));

                    // Yolcu bilgilerini almak için yeni formu aç
                    using (Ödeme_form form = new Ödeme_form(koltukNo))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            // Eğer bilgileri alırsak, CheckBox'u devre dışı bırak
                            selectedCheckBox.Enabled = false;
                            selectedCheckBox.Checked = false; // CheckBox'u işaretsiz hale getirin
                            MessageBox.Show("Ödeme tamamlanmıştır.");
                        }
                        else
                        {
                            // İşlem iptal edilirse, kalan adımları durdur
                            break;
                        }
                    }
                }
            }



        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            biletbilgileri blt = new biletbilgileri();
            blt.Show();
            this.Close();
        }


        public string LabelText
        {
            get { return label23.Text; }
            set { label23.Text = value; }
        }
    }
}
