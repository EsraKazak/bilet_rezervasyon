namespace bilet_rezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        admin_form adminf = new admin_form();
        Firma_girisf firmaf = new Firma_girisf();
        bilet_bul blt=new bilet_bul();

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // labelin arka planýný gizleme
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            adminf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firmaf.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            blt.Show();
            this.Hide();
        }
    }
}
