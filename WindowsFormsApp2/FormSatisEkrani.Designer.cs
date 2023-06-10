namespace WindowsFormsApp2
{
    partial class FormSatisEkrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSatisEkrani));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelad = new System.Windows.Forms.Label();
            this.labelfiyat = new System.Windows.Forms.Label();
            this.labeltip = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.labelkullanici = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelindirim = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labeltarih = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.maskedTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maskedTextBox1.Location = new System.Drawing.Point(142, 69);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox1.Mask = "0000000000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(183, 27);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.maskedTextBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maskedTextBox2.Location = new System.Drawing.Point(142, 104);
            this.maskedTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox2.Mask = "00/00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(63, 27);
            this.maskedTextBox2.TabIndex = 1;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox2.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.BackColor = System.Drawing.Color.LavenderBlush;
            this.maskedTextBox3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.maskedTextBox3.Location = new System.Drawing.Point(142, 139);
            this.maskedTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox3.Mask = "000";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(63, 27);
            this.maskedTextBox3.TabIndex = 2;
            this.maskedTextBox3.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.DarkViolet;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kart Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.ForeColor = System.Drawing.Color.DarkViolet;
            this.label2.Location = new System.Drawing.Point(84, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarih";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.ForeColor = System.Drawing.Color.DarkViolet;
            this.label3.Location = new System.Drawing.Point(88, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "CVV";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.maskedTextBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 241);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIN ALMA İŞLEMLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Violet;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.DarkViolet;
            this.button1.Location = new System.Drawing.Point(278, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "SATIN AL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.ForeColor = System.Drawing.Color.DarkViolet;
            this.label4.Location = new System.Drawing.Point(35, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kart Sahibi";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(142, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(281, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(602, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // labelad
            // 
            this.labelad.AutoSize = true;
            this.labelad.BackColor = System.Drawing.Color.Black;
            this.labelad.Location = new System.Drawing.Point(674, 19);
            this.labelad.Name = "labelad";
            this.labelad.Size = new System.Drawing.Size(98, 20);
            this.labelad.TabIndex = 9;
            this.labelad.Text = "ÜRÜN ADI";
            // 
            // labelfiyat
            // 
            this.labelfiyat.AutoSize = true;
            this.labelfiyat.BackColor = System.Drawing.Color.Black;
            this.labelfiyat.Location = new System.Drawing.Point(685, 376);
            this.labelfiyat.Name = "labelfiyat";
            this.labelfiyat.Size = new System.Drawing.Size(59, 20);
            this.labelfiyat.TabIndex = 47;
            this.labelfiyat.Text = "FİYAT";
            // 
            // labeltip
            // 
            this.labeltip.AutoSize = true;
            this.labeltip.BackColor = System.Drawing.Color.Black;
            this.labeltip.Location = new System.Drawing.Point(674, 347);
            this.labeltip.Name = "labeltip";
            this.labeltip.Size = new System.Drawing.Size(100, 20);
            this.labeltip.TabIndex = 49;
            this.labeltip.Text = "ÜRÜN TİPİ";
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(740, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "TL";
            // 
            // labelkullanici
            // 
            this.labelkullanici.AutoSize = true;
            this.labelkullanici.BackColor = System.Drawing.Color.Transparent;
            this.labelkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelkullanici.ForeColor = System.Drawing.Color.DeepPink;
            this.labelkullanici.Location = new System.Drawing.Point(13, 488);
            this.labelkullanici.Name = "labelkullanici";
            this.labelkullanici.Size = new System.Drawing.Size(81, 20);
            this.labelkullanici.TabIndex = 51;
            this.labelkullanici.Text = "Kullanıcı";
            this.labelkullanici.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LavenderBlush;
            this.textBox2.Location = new System.Drawing.Point(111, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(188, 27);
            this.textBox2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Violet;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.DarkViolet;
            this.button2.Location = new System.Drawing.Point(111, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "İNDİRİM UYGULA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.labelindirim);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.groupBox2.Location = new System.Drawing.Point(2, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 209);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İNDİRİM İŞLEMLERİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(267, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "TL";
            // 
            // labelindirim
            // 
            this.labelindirim.AutoSize = true;
            this.labelindirim.BackColor = System.Drawing.Color.Black;
            this.labelindirim.Location = new System.Drawing.Point(226, 173);
            this.labelindirim.Name = "labelindirim";
            this.labelindirim.Size = new System.Drawing.Size(19, 20);
            this.labelindirim.TabIndex = 54;
            this.labelindirim.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(107, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "İndirimTutarı :";
            // 
            // labeltarih
            // 
            this.labeltarih.AutoSize = true;
            this.labeltarih.BackColor = System.Drawing.Color.Transparent;
            this.labeltarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltarih.ForeColor = System.Drawing.Color.DeepPink;
            this.labeltarih.Location = new System.Drawing.Point(813, 488);
            this.labeltarih.Name = "labeltarih";
            this.labeltarih.Size = new System.Drawing.Size(52, 20);
            this.labeltarih.TabIndex = 52;
            this.labeltarih.Text = "Tarih";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumVioletRed;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(489, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "İŞLEMİ İPTAL ET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormSatisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(958, 517);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.labeltarih);
            this.Controls.Add(this.labelkullanici);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labeltip);
            this.Controls.Add(this.labelfiyat);
            this.Controls.Add(this.labelad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.DeepPink;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormSatisEkrani";
            this.Text = "FormSatisEkrani";
            this.Load += new System.EventHandler(this.FormSatisEkrani_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelad;
        private System.Windows.Forms.Label labelfiyat;
        private System.Windows.Forms.Label labeltip;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelkullanici;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labeltarih;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelindirim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
    }
}