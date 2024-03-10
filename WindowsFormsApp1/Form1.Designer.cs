
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePickerCagriTarihi = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.txtGsm = new System.Windows.Forms.TextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.chkKurs_Python = new System.Windows.Forms.CheckBox();
            this.chkKurs_Scratch = new System.Windows.Forms.CheckBox();
            this.chkKurs_KodlamaSovalyesi = new System.Windows.Forms.CheckBox();
            this.chkKurs_Roblox = new System.Windows.Forms.CheckBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.chkHoca_Ece = new System.Windows.Forms.CheckBox();
            this.chkHoca_Leyla = new System.Windows.Forms.CheckBox();
            this.chkHoca_Mustafa = new System.Windows.Forms.CheckBox();
            this.chkHoca_Ozge = new System.Windows.Forms.CheckBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerRandevuTarihi = new System.Windows.Forms.DateTimePicker();
            this.txtAmoLinki = new System.Windows.Forms.TextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.chkRandevuAlindi = new System.Windows.Forms.CheckBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.flowLayoutPanelHocalar = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelKurslar = new System.Windows.Forms.FlowLayoutPanel();
            this.listViewRandevular = new System.Windows.Forms.ListView();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkRandevuGirdi = new System.Windows.Forms.CheckBox();
            this.chkRandevuIptal = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerCagriTarihi
            // 
            this.dateTimePickerCagriTarihi.Location = new System.Drawing.Point(168, 12);
            this.dateTimePickerCagriTarihi.Name = "dateTimePickerCagriTarihi";
            this.dateTimePickerCagriTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCagriTarihi.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(31, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(131, 22);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Çağrı Tarihi";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(31, 51);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(131, 22);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "Telefon Numarası";
            // 
            // txtGsm
            // 
            this.txtGsm.Location = new System.Drawing.Point(168, 51);
            this.txtGsm.Name = "txtGsm";
            this.txtGsm.Size = new System.Drawing.Size(200, 22);
            this.txtGsm.TabIndex = 3;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox3.Location = new System.Drawing.Point(31, 96);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(130, 51);
            this.richTextBox3.TabIndex = 4;
            this.richTextBox3.Text = "Kurs Seçimi";
            // 
            // chkKurs_Python
            // 
            this.chkKurs_Python.AutoSize = true;
            this.chkKurs_Python.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkKurs_Python.Location = new System.Drawing.Point(168, 97);
            this.chkKurs_Python.Name = "chkKurs_Python";
            this.chkKurs_Python.Size = new System.Drawing.Size(74, 21);
            this.chkKurs_Python.TabIndex = 5;
            this.chkKurs_Python.Text = "Python";
            this.chkKurs_Python.UseVisualStyleBackColor = true;
            // 
            // chkKurs_Scratch
            // 
            this.chkKurs_Scratch.AutoSize = true;
            this.chkKurs_Scratch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkKurs_Scratch.Location = new System.Drawing.Point(248, 98);
            this.chkKurs_Scratch.Name = "chkKurs_Scratch";
            this.chkKurs_Scratch.Size = new System.Drawing.Size(78, 21);
            this.chkKurs_Scratch.TabIndex = 6;
            this.chkKurs_Scratch.Text = "Scratch";
            this.chkKurs_Scratch.UseVisualStyleBackColor = true;
            // 
            // chkKurs_KodlamaSovalyesi
            // 
            this.chkKurs_KodlamaSovalyesi.AutoSize = true;
            this.chkKurs_KodlamaSovalyesi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkKurs_KodlamaSovalyesi.Location = new System.Drawing.Point(248, 124);
            this.chkKurs_KodlamaSovalyesi.Name = "chkKurs_KodlamaSovalyesi";
            this.chkKurs_KodlamaSovalyesi.Size = new System.Drawing.Size(149, 21);
            this.chkKurs_KodlamaSovalyesi.TabIndex = 7;
            this.chkKurs_KodlamaSovalyesi.Text = "Kodlama Şövalyesi";
            this.chkKurs_KodlamaSovalyesi.UseVisualStyleBackColor = true;
            // 
            // chkKurs_Roblox
            // 
            this.chkKurs_Roblox.AutoSize = true;
            this.chkKurs_Roblox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkKurs_Roblox.Location = new System.Drawing.Point(169, 125);
            this.chkKurs_Roblox.Name = "chkKurs_Roblox";
            this.chkKurs_Roblox.Size = new System.Drawing.Size(73, 21);
            this.chkKurs_Roblox.TabIndex = 8;
            this.chkKurs_Roblox.Text = "Roblox";
            this.chkKurs_Roblox.UseVisualStyleBackColor = true;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(31, 183);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.Size = new System.Drawing.Size(131, 49);
            this.richTextBox4.TabIndex = 9;
            this.richTextBox4.Text = "Eğitmen Seçenekleri";
            // 
            // chkHoca_Ece
            // 
            this.chkHoca_Ece.AutoSize = true;
            this.chkHoca_Ece.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHoca_Ece.Location = new System.Drawing.Point(169, 184);
            this.chkHoca_Ece.Name = "chkHoca_Ece";
            this.chkHoca_Ece.Size = new System.Drawing.Size(54, 21);
            this.chkHoca_Ece.TabIndex = 10;
            this.chkHoca_Ece.Text = "Ece";
            this.chkHoca_Ece.UseVisualStyleBackColor = true;
            // 
            // chkHoca_Leyla
            // 
            this.chkHoca_Leyla.AutoSize = true;
            this.chkHoca_Leyla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHoca_Leyla.Location = new System.Drawing.Point(255, 183);
            this.chkHoca_Leyla.Name = "chkHoca_Leyla";
            this.chkHoca_Leyla.Size = new System.Drawing.Size(64, 21);
            this.chkHoca_Leyla.TabIndex = 11;
            this.chkHoca_Leyla.Text = "Leyla";
            this.chkHoca_Leyla.UseVisualStyleBackColor = true;
            // 
            // chkHoca_Mustafa
            // 
            this.chkHoca_Mustafa.AutoSize = true;
            this.chkHoca_Mustafa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHoca_Mustafa.Location = new System.Drawing.Point(169, 211);
            this.chkHoca_Mustafa.Name = "chkHoca_Mustafa";
            this.chkHoca_Mustafa.Size = new System.Drawing.Size(80, 21);
            this.chkHoca_Mustafa.TabIndex = 12;
            this.chkHoca_Mustafa.Text = "Mustafa";
            this.chkHoca_Mustafa.UseVisualStyleBackColor = true;
            // 
            // chkHoca_Ozge
            // 
            this.chkHoca_Ozge.AutoSize = true;
            this.chkHoca_Ozge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkHoca_Ozge.Location = new System.Drawing.Point(255, 210);
            this.chkHoca_Ozge.Name = "chkHoca_Ozge";
            this.chkHoca_Ozge.Size = new System.Drawing.Size(64, 21);
            this.chkHoca_Ozge.TabIndex = 13;
            this.chkHoca_Ozge.Text = "Özge";
            this.chkHoca_Ozge.UseVisualStyleBackColor = true;
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(403, 10);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.Size = new System.Drawing.Size(131, 22);
            this.richTextBox5.TabIndex = 14;
            this.richTextBox5.Text = "Randevu Tarihi";
            // 
            // dateTimePickerRandevuTarihi
            // 
            this.dateTimePickerRandevuTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerRandevuTarihi.Location = new System.Drawing.Point(540, 12);
            this.dateTimePickerRandevuTarihi.Name = "dateTimePickerRandevuTarihi";
            this.dateTimePickerRandevuTarihi.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRandevuTarihi.TabIndex = 15;
            // 
            // txtAmoLinki
            // 
            this.txtAmoLinki.Location = new System.Drawing.Point(540, 95);
            this.txtAmoLinki.Name = "txtAmoLinki";
            this.txtAmoLinki.Size = new System.Drawing.Size(200, 22);
            this.txtAmoLinki.TabIndex = 16;
            // 
            // richTextBox6
            // 
            this.richTextBox6.Location = new System.Drawing.Point(403, 95);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(131, 22);
            this.richTextBox6.TabIndex = 17;
            this.richTextBox6.Text = "Ammocrm Linki";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Location = new System.Drawing.Point(403, 156);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(131, 76);
            this.richTextBox7.TabIndex = 18;
            this.richTextBox7.Text = "Randevu Durumu";
            // 
            // chkRandevuAlindi
            // 
            this.chkRandevuAlindi.AutoSize = true;
            this.chkRandevuAlindi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRandevuAlindi.Location = new System.Drawing.Point(540, 156);
            this.chkRandevuAlindi.Name = "chkRandevuAlindi";
            this.chkRandevuAlindi.Size = new System.Drawing.Size(125, 21);
            this.chkRandevuAlindi.TabIndex = 19;
            this.chkRandevuAlindi.Text = "Randevu Alındı";
            this.chkRandevuAlindi.UseVisualStyleBackColor = true;
            // 
            // richTextBox8
            // 
            this.richTextBox8.Location = new System.Drawing.Point(31, 264);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(131, 22);
            this.richTextBox8.TabIndex = 23;
            this.richTextBox8.Text = "İsim Soyisim";
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LawnGreen;
            this.btnKaydet.Location = new System.Drawing.Point(455, 302);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(202, 148);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // flowLayoutPanelHocalar
            // 
            this.flowLayoutPanelHocalar.Location = new System.Drawing.Point(31, 322);
            this.flowLayoutPanelHocalar.Name = "flowLayoutPanelHocalar";
            this.flowLayoutPanelHocalar.Size = new System.Drawing.Size(77, 20);
            this.flowLayoutPanelHocalar.TabIndex = 25;
            // 
            // flowLayoutPanelKurslar
            // 
            this.flowLayoutPanelKurslar.Location = new System.Drawing.Point(185, 322);
            this.flowLayoutPanelKurslar.Name = "flowLayoutPanelKurslar";
            this.flowLayoutPanelKurslar.Size = new System.Drawing.Size(76, 20);
            this.flowLayoutPanelKurslar.TabIndex = 26;
            // 
            // listViewRandevular
            // 
            this.listViewRandevular.HideSelection = false;
            this.listViewRandevular.Location = new System.Drawing.Point(746, 10);
            this.listViewRandevular.Name = "listViewRandevular";
            this.listViewRandevular.Size = new System.Drawing.Size(1400, 800);
            this.listViewRandevular.TabIndex = 27;
            this.listViewRandevular.UseCompatibleStateImageBehavior = false;
            this.listViewRandevular.View = System.Windows.Forms.View.Details;
            // 
            // richTextBox9
            // 
            this.richTextBox9.Location = new System.Drawing.Point(403, 262);
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.Size = new System.Drawing.Size(131, 22);
            this.richTextBox9.TabIndex = 28;
            this.richTextBox9.Text = "Data Kaynağı";
            this.richTextBox9.TextChanged += new System.EventHandler(this.richTextBox9_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(555, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.Text = "Ulaşılamadı";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(552, 457);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(154, 17);
            this.linkLabel1.TabIndex = 31;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://ogubenn.com.tr/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.linkLabel2.Location = new System.Drawing.Point(28, 446);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(363, 17);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://ogubenn.com.tr/meeting.php?action=viewMeeting";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(168, 262);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 24);
            this.comboBox2.TabIndex = 33;
            this.comboBox2.Text = "Seçiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 302);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 120);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // chkRandevuGirdi
            // 
            this.chkRandevuGirdi.AutoSize = true;
            this.chkRandevuGirdi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRandevuGirdi.Location = new System.Drawing.Point(540, 210);
            this.chkRandevuGirdi.Name = "chkRandevuGirdi";
            this.chkRandevuGirdi.Size = new System.Drawing.Size(136, 21);
            this.chkRandevuGirdi.TabIndex = 21;
            this.chkRandevuGirdi.Text = "Randevuya Girdi";
            this.chkRandevuGirdi.UseVisualStyleBackColor = true;
            // 
            // chkRandevuIptal
            // 
            this.chkRandevuIptal.AutoSize = true;
            this.chkRandevuIptal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkRandevuIptal.Location = new System.Drawing.Point(540, 183);
            this.chkRandevuIptal.Name = "chkRandevuIptal";
            this.chkRandevuIptal.Size = new System.Drawing.Size(117, 21);
            this.chkRandevuIptal.TabIndex = 20;
            this.chkRandevuIptal.Text = "Randevu İptal";
            this.chkRandevuIptal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1839, 794);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.listViewRandevular);
            this.Controls.Add(this.flowLayoutPanelKurslar);
            this.Controls.Add(this.flowLayoutPanelHocalar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.chkRandevuGirdi);
            this.Controls.Add(this.chkRandevuIptal);
            this.Controls.Add(this.chkRandevuAlindi);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.txtAmoLinki);
            this.Controls.Add(this.dateTimePickerRandevuTarihi);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.chkHoca_Ozge);
            this.Controls.Add(this.chkHoca_Mustafa);
            this.Controls.Add(this.chkHoca_Leyla);
            this.Controls.Add(this.chkHoca_Ece);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.chkKurs_Roblox);
            this.Controls.Add(this.chkKurs_KodlamaSovalyesi);
            this.Controls.Add(this.chkKurs_Scratch);
            this.Controls.Add(this.chkKurs_Python);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.txtGsm);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePickerCagriTarihi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerCagriTarihi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox txtGsm;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.CheckBox chkKurs_Python;
        private System.Windows.Forms.CheckBox chkKurs_Scratch;
        private System.Windows.Forms.CheckBox chkKurs_KodlamaSovalyesi;
        private System.Windows.Forms.CheckBox chkKurs_Roblox;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.CheckBox chkHoca_Ece;
        private System.Windows.Forms.CheckBox chkHoca_Leyla;
        private System.Windows.Forms.CheckBox chkHoca_Mustafa;
        private System.Windows.Forms.CheckBox chkHoca_Ozge;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.DateTimePicker dateTimePickerRandevuTarihi;
        private System.Windows.Forms.TextBox txtAmoLinki;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.CheckBox chkRandevuAlindi;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelHocalar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelKurslar;
        private System.Windows.Forms.ListView listViewRandevular;
        private System.Windows.Forms.RichTextBox richTextBox9;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkRandevuGirdi;
        private System.Windows.Forms.CheckBox chkRandevuIptal;
    }
}

