
namespace KursOtomasyonu
{
    partial class EgitmenKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgitmenKayit));
            this.btnEgitmenSil = new System.Windows.Forms.Button();
            this.btnEgitmenTemizle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEgitmenAdi = new System.Windows.Forms.TextBox();
            this.btnEgitmenEkle = new System.Windows.Forms.Button();
            this.dtgEgitmenList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEgitmenList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEgitmenSil
            // 
            this.btnEgitmenSil.Image = ((System.Drawing.Image)(resources.GetObject("btnEgitmenSil.Image")));
            this.btnEgitmenSil.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEgitmenSil.Location = new System.Drawing.Point(33, 254);
            this.btnEgitmenSil.Name = "btnEgitmenSil";
            this.btnEgitmenSil.Size = new System.Drawing.Size(90, 88);
            this.btnEgitmenSil.TabIndex = 16;
            this.btnEgitmenSil.Text = "Sil";
            this.btnEgitmenSil.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEgitmenSil.UseVisualStyleBackColor = true;
            this.btnEgitmenSil.Click += new System.EventHandler(this.btnEgitmenSil_Click);
            // 
            // btnEgitmenTemizle
            // 
            this.btnEgitmenTemizle.Image = ((System.Drawing.Image)(resources.GetObject("btnEgitmenTemizle.Image")));
            this.btnEgitmenTemizle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEgitmenTemizle.Location = new System.Drawing.Point(33, 361);
            this.btnEgitmenTemizle.Name = "btnEgitmenTemizle";
            this.btnEgitmenTemizle.Size = new System.Drawing.Size(90, 87);
            this.btnEgitmenTemizle.TabIndex = 15;
            this.btnEgitmenTemizle.Text = "Temizle";
            this.btnEgitmenTemizle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEgitmenTemizle.UseVisualStyleBackColor = true;
            this.btnEgitmenTemizle.Click += new System.EventHandler(this.btnEgitmenTemizle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maaş";
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(107, 148);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(191, 22);
            this.txtMaas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Branş";
            // 
            // txtBrans
            // 
            this.txtBrans.Location = new System.Drawing.Point(107, 94);
            this.txtBrans.Name = "txtBrans";
            this.txtBrans.Size = new System.Drawing.Size(191, 22);
            this.txtBrans.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // txtEgitmenAdi
            // 
            this.txtEgitmenAdi.Location = new System.Drawing.Point(107, 43);
            this.txtEgitmenAdi.Name = "txtEgitmenAdi";
            this.txtEgitmenAdi.Size = new System.Drawing.Size(191, 22);
            this.txtEgitmenAdi.TabIndex = 2;
            // 
            // btnEgitmenEkle
            // 
            this.btnEgitmenEkle.Image = global::KursOtomasyonu.Properties.Resources.ogrenciekle;
            this.btnEgitmenEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEgitmenEkle.Location = new System.Drawing.Point(168, 277);
            this.btnEgitmenEkle.Name = "btnEgitmenEkle";
            this.btnEgitmenEkle.Size = new System.Drawing.Size(130, 107);
            this.btnEgitmenEkle.TabIndex = 1;
            this.btnEgitmenEkle.Text = "  Eğitmen Ekle";
            this.btnEgitmenEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEgitmenEkle.UseVisualStyleBackColor = true;
            this.btnEgitmenEkle.Click += new System.EventHandler(this.btnEgitmenEkle_Click);
            // 
            // dtgEgitmenList
            // 
            this.dtgEgitmenList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEgitmenList.Location = new System.Drawing.Point(322, 21);
            this.dtgEgitmenList.Name = "dtgEgitmenList";
            this.dtgEgitmenList.RowHeadersWidth = 51;
            this.dtgEgitmenList.RowTemplate.Height = 24;
            this.dtgEgitmenList.Size = new System.Drawing.Size(782, 499);
            this.dtgEgitmenList.TabIndex = 0;
            this.dtgEgitmenList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEgitmenList_CellContentClick_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTcNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnEgitmenSil);
            this.groupBox1.Controls.Add(this.btnEgitmenTemizle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBrans);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEgitmenAdi);
            this.groupBox1.Controls.Add(this.btnEgitmenEkle);
            this.groupBox1.Controls.Add(this.dtgEgitmenList);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1110, 526);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eğitmen Ekleme";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "TcNo";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(107, 201);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(191, 22);
            this.txtTcNo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Eğitmen Adı";
            // 
            // EgitmenKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1140, 547);
            this.Controls.Add(this.groupBox1);
            this.Name = "EgitmenKayit";
            this.Text = "Egitmen";
            this.Load += new System.EventHandler(this.EgitmenKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEgitmenList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEgitmenSil;
        private System.Windows.Forms.Button btnEgitmenTemizle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEgitmenAdi;
        private System.Windows.Forms.Button btnEgitmenEkle;
        private System.Windows.Forms.DataGridView dtgEgitmenList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label7;
    }
}