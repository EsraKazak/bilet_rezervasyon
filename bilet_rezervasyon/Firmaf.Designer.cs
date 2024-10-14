namespace bilet_rezervasyon
{
    partial class Firmaf
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
            firmanamelabel = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            listfirma = new ListBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // firmanamelabel
            // 
            firmanamelabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            firmanamelabel.Location = new Point(474, 9);
            firmanamelabel.Name = "firmanamelabel";
            firmanamelabel.Size = new Size(243, 86);
            firmanamelabel.TabIndex = 0;
            firmanamelabel.Text = "label1";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(35, 98);
            label1.Name = "label1";
            label1.Size = new Size(104, 27);
            label1.TabIndex = 5;
            label1.Text = "Araç Adı";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(35, 163);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 6;
            label2.Text = "Sefer Türü";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(35, 230);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 7;
            label3.Text = "Güzergah";
            // 
            // button1
            // 
            button1.Location = new Point(53, 373);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(207, 373);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "SİL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listfirma
            // 
            listfirma.FormattingEnabled = true;
            listfirma.Location = new Point(337, 51);
            listfirma.Name = "listfirma";
            listfirma.Size = new Size(686, 364);
            listfirma.TabIndex = 10;
            listfirma.SelectedIndexChanged += listfirma_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(145, 162);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(128, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(145, 230);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(128, 27);
            textBox3.TabIndex = 13;
            // 
            // Firmaf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 450);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listfirma);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(firmanamelabel);
            Name = "Firmaf";
            Text = "Firmaf";
            Load += Firmaf_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firmanamelabel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private ListBox listfirma;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}