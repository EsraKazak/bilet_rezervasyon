namespace bilet_rezervasyon
{
    partial class admin_islem
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFirmaAdi = new TextBox();
            txtAdres = new TextBox();
            txtTel = new MaskedTextBox();
            label4 = new Label();
            txtUcret = new TextBox();
            sil_btn = new Button();
            EKLE_BTN = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listfirma = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(60, 35);
            label1.Name = "label1";
            label1.Size = new Size(117, 41);
            label1.TabIndex = 0;
            label1.Text = "Firma Adı";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(60, 99);
            label2.Name = "label2";
            label2.Size = new Size(117, 41);
            label2.TabIndex = 1;
            label2.Text = "Adres";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(60, 156);
            label3.Name = "label3";
            label3.Size = new Size(117, 41);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // txtFirmaAdi
            // 
            txtFirmaAdi.Location = new Point(184, 36);
            txtFirmaAdi.Name = "txtFirmaAdi";
            txtFirmaAdi.Size = new Size(175, 27);
            txtFirmaAdi.TabIndex = 3;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(183, 103);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(176, 27);
            txtAdres.TabIndex = 4;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(183, 160);
            txtTel.Mask = "(999) 000-0000";
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(176, 27);
            txtTel.TabIndex = 5;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(25, 224);
            label4.Name = "label4";
            label4.Size = new Size(152, 41);
            label4.TabIndex = 7;
            label4.Text = "Hizmet Bedeli";
            // 
            // txtUcret
            // 
            txtUcret.Location = new Point(183, 228);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(176, 27);
            txtUcret.TabIndex = 8;
            txtUcret.TextChanged += textBox3_TextChanged;
            // 
            // sil_btn
            // 
            sil_btn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            sil_btn.Location = new Point(222, 312);
            sil_btn.Name = "sil_btn";
            sil_btn.Size = new Size(154, 49);
            sil_btn.TabIndex = 10;
            sil_btn.Text = "SİL";
            sil_btn.UseVisualStyleBackColor = true;
            sil_btn.Click += sil_btn_Click;
            // 
            // EKLE_BTN
            // 
            EKLE_BTN.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            EKLE_BTN.Location = new Point(12, 312);
            EKLE_BTN.Name = "EKLE_BTN";
            EKLE_BTN.Size = new Size(154, 49);
            EKLE_BTN.TabIndex = 11;
            EKLE_BTN.Text = "EKLE";
            EKLE_BTN.UseVisualStyleBackColor = true;
            EKLE_BTN.Click += EKLE_BTN_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(419, 11);
            label5.Name = "label5";
            label5.Size = new Size(117, 41);
            label5.TabIndex = 13;
            label5.Text = "Firma Adı";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(561, 11);
            label6.Name = "label6";
            label6.Size = new Size(117, 41);
            label6.TabIndex = 14;
            label6.Text = "Adres";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(695, 11);
            label7.Name = "label7";
            label7.Size = new Size(97, 41);
            label7.TabIndex = 15;
            label7.Text = "Tel No";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label8.Location = new Point(810, 11);
            label8.Name = "label8";
            label8.Size = new Size(142, 41);
            label8.TabIndex = 16;
            label8.Text = "Hizmet Bedeli";
            // 
            // listfirma
            // 
            listfirma.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            listfirma.FormattingEnabled = true;
            listfirma.ItemHeight = 37;
            listfirma.Location = new Point(419, 39);
            listfirma.Name = "listfirma";
            listfirma.Size = new Size(533, 337);
            listfirma.TabIndex = 17;
            listfirma.SelectedIndexChanged += listfirma_SelectedIndexChanged;
            // 
            // admin_islem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 450);
            Controls.Add(listfirma);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(EKLE_BTN);
            Controls.Add(sil_btn);
            Controls.Add(txtUcret);
            Controls.Add(label4);
            Controls.Add(txtTel);
            Controls.Add(txtAdres);
            Controls.Add(txtFirmaAdi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin_islem";
            Text = "admin_islem";
            Load += admin_islem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFirmaAdi;
        private TextBox txtAdres;
        private MaskedTextBox txtTel;
        private Label label4;
        private TextBox txtUcret;
        private Button sil_btn;
        private Button EKLE_BTN;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox listfirma;
    }
}