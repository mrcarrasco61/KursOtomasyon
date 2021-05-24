
namespace KursOtomasyonu
{
    partial class KursiyerAtama
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgKursiyer = new System.Windows.Forms.DataGridView();
            this.dtgKursList = new System.Windows.Forms.DataGridView();
            this.txtKursiyerId = new System.Windows.Forms.TextBox();
            this.txtKursId = new System.Windows.Forms.TextBox();
            this.dtgAtanan = new System.Windows.Forms.DataGridView();
            this.txtKursAdi = new System.Windows.Forms.TextBox();
            this.txtArananKursiyerId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKursiyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKursList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAtanan)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Kurs Ata";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgKursiyer);
            this.panel1.Location = new System.Drawing.Point(306, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 256);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgKursList);
            this.panel2.Location = new System.Drawing.Point(878, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 256);
            this.panel2.TabIndex = 4;
            // 
            // dtgKursiyer
            // 
            this.dtgKursiyer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKursiyer.Location = new System.Drawing.Point(3, 3);
            this.dtgKursiyer.Name = "dtgKursiyer";
            this.dtgKursiyer.RowHeadersWidth = 51;
            this.dtgKursiyer.RowTemplate.Height = 24;
            this.dtgKursiyer.Size = new System.Drawing.Size(549, 253);
            this.dtgKursiyer.TabIndex = 0;
            this.dtgKursiyer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKursiyer_CellContentClick);
            // 
            // dtgKursList
            // 
            this.dtgKursList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKursList.Location = new System.Drawing.Point(3, 3);
            this.dtgKursList.Name = "dtgKursList";
            this.dtgKursList.RowHeadersWidth = 51;
            this.dtgKursList.RowTemplate.Height = 24;
            this.dtgKursList.Size = new System.Drawing.Size(586, 253);
            this.dtgKursList.TabIndex = 0;
            this.dtgKursList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKursList_CellContentClick);
            // 
            // txtKursiyerId
            // 
            this.txtKursiyerId.Location = new System.Drawing.Point(113, 37);
            this.txtKursiyerId.Name = "txtKursiyerId";
            this.txtKursiyerId.Size = new System.Drawing.Size(128, 22);
            this.txtKursiyerId.TabIndex = 5;
            // 
            // txtKursId
            // 
            this.txtKursId.Location = new System.Drawing.Point(113, 83);
            this.txtKursId.Name = "txtKursId";
            this.txtKursId.Size = new System.Drawing.Size(126, 22);
            this.txtKursId.TabIndex = 6;
            // 
            // dtgAtanan
            // 
            this.dtgAtanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAtanan.Location = new System.Drawing.Point(306, 348);
            this.dtgAtanan.Name = "dtgAtanan";
            this.dtgAtanan.RowHeadersWidth = 51;
            this.dtgAtanan.RowTemplate.Height = 24;
            this.dtgAtanan.Size = new System.Drawing.Size(1147, 310);
            this.dtgAtanan.TabIndex = 1;
            this.dtgAtanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAtanan_CellContentClick);
            // 
            // txtKursAdi
            // 
            this.txtKursAdi.Location = new System.Drawing.Point(111, 457);
            this.txtKursAdi.Name = "txtKursAdi";
            this.txtKursAdi.Size = new System.Drawing.Size(126, 22);
            this.txtKursAdi.TabIndex = 9;
            // 
            // txtArananKursiyerId
            // 
            this.txtArananKursiyerId.Location = new System.Drawing.Point(111, 411);
            this.txtArananKursiyerId.Name = "txtArananKursiyerId";
            this.txtArananKursiyerId.Size = new System.Drawing.Size(128, 22);
            this.txtArananKursiyerId.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(122, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 48);
            this.button2.TabIndex = 7;
            this.button2.Text = "Atanmayı Kaldır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "KursiyerId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "KursId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kurs Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "KursiyerId";
            // 
            // KursiyerAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 695);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKursAdi);
            this.Controls.Add(this.txtArananKursiyerId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgAtanan);
            this.Controls.Add(this.txtKursId);
            this.Controls.Add(this.txtKursiyerId);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "KursiyerAtama";
            this.Text = "KursiyerAtama";
            this.Load += new System.EventHandler(this.KursiyerAtama_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKursiyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKursList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAtanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgKursiyer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgKursList;
        private System.Windows.Forms.TextBox txtKursiyerId;
        private System.Windows.Forms.TextBox txtKursId;
        private System.Windows.Forms.DataGridView dtgAtanan;
        private System.Windows.Forms.TextBox txtKursAdi;
        private System.Windows.Forms.TextBox txtArananKursiyerId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}