
namespace KursOtomasyonu
{
    partial class KursiyerDevamsizlik
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
            this.dtgDevamsizlikList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKursiyer = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDevamsizlikEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevamsizlikList)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgDevamsizlikList
            // 
            this.dtgDevamsizlikList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDevamsizlikList.Location = new System.Drawing.Point(330, 12);
            this.dtgDevamsizlikList.Name = "dtgDevamsizlikList";
            this.dtgDevamsizlikList.RowHeadersWidth = 51;
            this.dtgDevamsizlikList.RowTemplate.Height = 24;
            this.dtgDevamsizlikList.Size = new System.Drawing.Size(703, 499);
            this.dtgDevamsizlikList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Devamsızlık";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(121, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // cmbKursiyer
            // 
            this.cmbKursiyer.FormattingEnabled = true;
            this.cmbKursiyer.Location = new System.Drawing.Point(98, 25);
            this.cmbKursiyer.Name = "cmbKursiyer";
            this.cmbKursiyer.Size = new System.Drawing.Size(200, 24);
            this.cmbKursiyer.TabIndex = 3;
            this.cmbKursiyer.SelectedIndexChanged += new System.EventHandler(this.cmbKursiyerAd_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Öğrenci Adı";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(98, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = " Tarihi";
            // 
            // btnDevamsizlikEkle
            // 
            this.btnDevamsizlikEkle.Image = global::KursOtomasyonu.Properties.Resources.ogrenciekle;
            this.btnDevamsizlikEkle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDevamsizlikEkle.Location = new System.Drawing.Point(185, 175);
            this.btnDevamsizlikEkle.Name = "btnDevamsizlikEkle";
            this.btnDevamsizlikEkle.Size = new System.Drawing.Size(96, 98);
            this.btnDevamsizlikEkle.TabIndex = 7;
            this.btnDevamsizlikEkle.Text = "Ekle";
            this.btnDevamsizlikEkle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDevamsizlikEkle.UseVisualStyleBackColor = true;
            this.btnDevamsizlikEkle.Click += new System.EventHandler(this.btnDevamsizlikEkle_Click);
            // 
            // KursiyerDevamsizlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1045, 523);
            this.Controls.Add(this.btnDevamsizlikEkle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKursiyer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgDevamsizlikList);
            this.Name = "KursiyerDevamsizlik";
            this.Text = "KursiyerDevamsizlik";
            this.Load += new System.EventHandler(this.KursiyerDevamsizlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDevamsizlikList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgDevamsizlikList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKursiyer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDevamsizlikEkle;
    }
}