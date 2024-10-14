namespace bilet_rezervasyon
{
    partial class Firma_girisf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firma_girisf));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            kullanıcıA_textbox = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(384, 61);
            label1.TabIndex = 0;
            label1.Text = "Lütfen Firma Giriş Bilgilerini Giriniz";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(48, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 292);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // kullanıcıA_textbox
            // 
            kullanıcıA_textbox.Location = new Point(540, 108);
            kullanıcıA_textbox.Name = "kullanıcıA_textbox";
            kullanıcıA_textbox.Size = new Size(176, 27);
            kullanıcıA_textbox.TabIndex = 2;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(540, 203);
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(176, 27);
            maskedTextBox1.TabIndex = 3;
            maskedTextBox1.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(439, 108);
            label2.Name = "label2";
            label2.Size = new Size(95, 27);
            label2.TabIndex = 4;
            label2.Text = "Kullanıcı Adı";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(488, 203);
            label3.Name = "label3";
            label3.Size = new Size(46, 27);
            label3.TabIndex = 5;
            label3.Text = "Şifre";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(570, 280);
            button1.Name = "button1";
            button1.Size = new Size(117, 38);
            button1.TabIndex = 6;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Firma_girisf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(maskedTextBox1);
            Controls.Add(kullanıcıA_textbox);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Firma_girisf";
            Text = "Firma_girisf";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox kullanıcıA_textbox;
        private MaskedTextBox maskedTextBox1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}