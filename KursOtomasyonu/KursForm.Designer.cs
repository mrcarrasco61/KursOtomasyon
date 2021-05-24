
namespace KursOtomasyonu
{
    partial class KursForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KursForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKursAdi = new System.Windows.Forms.TextBox();
            this.btnKursEkle = new System.Windows.Forms.Button();
            this.dtgKursList = new System.Windows.Forms.DataGridView();
            this.dtgbSaati = new System.Windows.Forms.DateTimePicker();
            this.dtgbitisSaati = new System.Windows.Forms.DateTimePicker();
            this.dtpFiyat = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKursList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dtpFiyat);
            this.groupBox1.Controls.Add(this.dtgbitisSaati);
            this.groupBox1.Controls.Add(this.dtgbSaati);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BtnSil);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKursAdi);
            this.groupBox1.Controls.Add(this.btnKursEkle);
            this.groupBox1.Controls.Add(this.dtgKursList);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(-2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 558);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kurs Ekleme";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kurs Adı";
            // 
            // BtnSil
            // 
            this.BtnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSil.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.Image")));
            this.BtnSil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSil.Location = new System.Drawing.Point(33, 254);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(90, 88);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "Sil";
            this.BtnSil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnTemizle.Image")));
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTemizle.Location = new System.Drawing.Point(33, 361);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(90, 87);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(8, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bitiş Zamanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(-3, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Başlangıc Zamanı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // txtKursAdi
            // 
            this.txtKursAdi.Location = new System.Drawing.Point(107, 43);
            this.txtKursAdi.Name = "txtKursAdi";
            this.txtKursAdi.Size = new System.Drawing.Size(191, 22);
            this.txtKursAdi.TabIndex = 2;
            // 
            // btnKursEkle
            // 
            this.btnKursEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKursEkle.Image = global::KursOtomasyonu.Properties.Resources.ogrenciekle;
            this.btnKursEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKursEkle.Location = new System.Drawing.Point(168, 277);
            this.btnKursEkle.Name = "btnKursEkle";
            this.btnKursEkle.Size = new System.Drawing.Size(130, 107);
            this.btnKursEkle.TabIndex = 1;
            this.btnKursEkle.Text = "Kurs Ekle\r\n";
            this.btnKursEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKursEkle.UseVisualStyleBackColor = true;
            this.btnKursEkle.Click += new System.EventHandler(this.btnKursEkle_Click);
            // 
            // dtgKursList
            // 
            this.dtgKursList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKursList.Dock = System.Windows.Forms.DockStyle.Right;
            this.dtgKursList.Location = new System.Drawing.Point(339, 18);
            this.dtgKursList.Name = "dtgKursList";
            this.dtgKursList.RowHeadersWidth = 51;
            this.dtgKursList.RowTemplate.Height = 24;
            this.dtgKursList.Size = new System.Drawing.Size(782, 537);
            this.dtgKursList.TabIndex = 0;
            this.dtgKursList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKursList_CellContentClick);
            // 
            // dtgbSaati
            // 
            this.dtgbSaati.Location = new System.Drawing.Point(108, 94);
            this.dtgbSaati.Name = "dtgbSaati";
            this.dtgbSaati.Size = new System.Drawing.Size(200, 22);
            this.dtgbSaati.TabIndex = 20;
            // 
            // dtgbitisSaati
            // 
            this.dtgbitisSaati.Location = new System.Drawing.Point(108, 153);
            this.dtgbitisSaati.Name = "dtgbitisSaati";
            this.dtgbitisSaati.Size = new System.Drawing.Size(200, 22);
            this.dtgbitisSaati.TabIndex = 21;
            // 
            // dtpFiyat
            // 
            this.dtpFiyat.Location = new System.Drawing.Point(107, 199);
            this.dtpFiyat.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.dtpFiyat.Name = "dtpFiyat";
            this.dtpFiyat.Size = new System.Drawing.Size(191, 22);
            this.dtpFiyat.TabIndex = 22;
            // 
            // KursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 560);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "KursForm";
            this.Text = "KursForm";
            this.Load += new System.EventHandler(this.KursForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKursList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKursAdi;
        private System.Windows.Forms.Button btnKursEkle;
        private System.Windows.Forms.DataGridView dtgKursList;
        private System.Windows.Forms.DateTimePicker dtgbitisSaati;
        private System.Windows.Forms.DateTimePicker dtgbSaati;
        private System.Windows.Forms.NumericUpDown dtpFiyat;
    }
}