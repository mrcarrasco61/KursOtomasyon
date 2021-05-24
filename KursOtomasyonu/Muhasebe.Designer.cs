
namespace KursOtomasyonu
{
    partial class Muhasebe
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
            this.dtgOgrenciOdeme = new System.Windows.Forms.DataGridView();
            this.dtgEgitmenOdeme = new System.Windows.Forms.DataGridView();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.lblKursiyerId = new System.Windows.Forms.Label();
            this.lblKursiyerAdi = new System.Windows.Forms.Label();
            this.lblKursiyerNo = new System.Windows.Forms.Label();
            this.lblEgitmenId = new System.Windows.Forms.Label();
            this.lblEgitmenAd = new System.Windows.Forms.Label();
            this.lblEgitmenNo = new System.Windows.Forms.Label();
            this.btnEgitmenOde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgrenciOdeme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEgitmenOdeme)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgOgrenciOdeme
            // 
            this.dtgOgrenciOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOgrenciOdeme.Location = new System.Drawing.Point(32, 21);
            this.dtgOgrenciOdeme.Name = "dtgOgrenciOdeme";
            this.dtgOgrenciOdeme.RowHeadersWidth = 51;
            this.dtgOgrenciOdeme.RowTemplate.Height = 24;
            this.dtgOgrenciOdeme.Size = new System.Drawing.Size(657, 253);
            this.dtgOgrenciOdeme.TabIndex = 1;
            this.dtgOgrenciOdeme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgOgrenciOdeme_CellContentClick);
            // 
            // dtgEgitmenOdeme
            // 
            this.dtgEgitmenOdeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEgitmenOdeme.Location = new System.Drawing.Point(32, 297);
            this.dtgEgitmenOdeme.Name = "dtgEgitmenOdeme";
            this.dtgEgitmenOdeme.RowHeadersWidth = 51;
            this.dtgEgitmenOdeme.RowTemplate.Height = 24;
            this.dtgEgitmenOdeme.Size = new System.Drawing.Size(657, 253);
            this.dtgEgitmenOdeme.TabIndex = 2;
            this.dtgEgitmenOdeme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEgitmenOdeme_CellContentClick);
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(752, 21);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(97, 58);
            this.btnOdeme.TabIndex = 3;
            this.btnOdeme.Text = "Öğrenciye Ödeme Yap";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // lblKursiyerId
            // 
            this.lblKursiyerId.AutoSize = true;
            this.lblKursiyerId.Location = new System.Drawing.Point(752, 99);
            this.lblKursiyerId.Name = "lblKursiyerId";
            this.lblKursiyerId.Size = new System.Drawing.Size(16, 17);
            this.lblKursiyerId.TabIndex = 4;
            this.lblKursiyerId.Text = "0";
            // 
            // lblKursiyerAdi
            // 
            this.lblKursiyerAdi.AutoSize = true;
            this.lblKursiyerAdi.Location = new System.Drawing.Point(752, 133);
            this.lblKursiyerAdi.Name = "lblKursiyerAdi";
            this.lblKursiyerAdi.Size = new System.Drawing.Size(16, 17);
            this.lblKursiyerAdi.TabIndex = 5;
            this.lblKursiyerAdi.Text = "0";
            // 
            // lblKursiyerNo
            // 
            this.lblKursiyerNo.AutoSize = true;
            this.lblKursiyerNo.Location = new System.Drawing.Point(752, 171);
            this.lblKursiyerNo.Name = "lblKursiyerNo";
            this.lblKursiyerNo.Size = new System.Drawing.Size(16, 17);
            this.lblKursiyerNo.TabIndex = 6;
            this.lblKursiyerNo.Text = "0";
            // 
            // lblEgitmenId
            // 
            this.lblEgitmenId.AutoSize = true;
            this.lblEgitmenId.Location = new System.Drawing.Point(752, 387);
            this.lblEgitmenId.Name = "lblEgitmenId";
            this.lblEgitmenId.Size = new System.Drawing.Size(16, 17);
            this.lblEgitmenId.TabIndex = 7;
            this.lblEgitmenId.Text = "0";
            // 
            // lblEgitmenAd
            // 
            this.lblEgitmenAd.AutoSize = true;
            this.lblEgitmenAd.Location = new System.Drawing.Point(752, 423);
            this.lblEgitmenAd.Name = "lblEgitmenAd";
            this.lblEgitmenAd.Size = new System.Drawing.Size(16, 17);
            this.lblEgitmenAd.TabIndex = 8;
            this.lblEgitmenAd.Text = "0";
            // 
            // lblEgitmenNo
            // 
            this.lblEgitmenNo.AutoSize = true;
            this.lblEgitmenNo.Location = new System.Drawing.Point(752, 462);
            this.lblEgitmenNo.Name = "lblEgitmenNo";
            this.lblEgitmenNo.Size = new System.Drawing.Size(16, 17);
            this.lblEgitmenNo.TabIndex = 9;
            this.lblEgitmenNo.Text = "0";
            // 
            // btnEgitmenOde
            // 
            this.btnEgitmenOde.Location = new System.Drawing.Point(752, 297);
            this.btnEgitmenOde.Name = "btnEgitmenOde";
            this.btnEgitmenOde.Size = new System.Drawing.Size(97, 58);
            this.btnEgitmenOde.TabIndex = 10;
            this.btnEgitmenOde.Text = "Eğitmene Ödeme Yap";
            this.btnEgitmenOde.UseVisualStyleBackColor = true;
            this.btnEgitmenOde.Click += new System.EventHandler(this.btnEgitmenOde_Click);
            // 
            // Muhasebe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(991, 573);
            this.Controls.Add(this.btnEgitmenOde);
            this.Controls.Add(this.lblEgitmenNo);
            this.Controls.Add(this.lblEgitmenAd);
            this.Controls.Add(this.lblEgitmenId);
            this.Controls.Add(this.lblKursiyerNo);
            this.Controls.Add(this.lblKursiyerAdi);
            this.Controls.Add(this.lblKursiyerId);
            this.Controls.Add(this.btnOdeme);
            this.Controls.Add(this.dtgEgitmenOdeme);
            this.Controls.Add(this.dtgOgrenciOdeme);
            this.Name = "Muhasebe";
            this.Text = "Muhasebe";
            this.Load += new System.EventHandler(this.Muhasebe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOgrenciOdeme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEgitmenOdeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOgrenciOdeme;
        private System.Windows.Forms.DataGridView dtgEgitmenOdeme;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.Label lblKursiyerId;
        private System.Windows.Forms.Label lblKursiyerAdi;
        private System.Windows.Forms.Label lblKursiyerNo;
        private System.Windows.Forms.Label lblEgitmenId;
        private System.Windows.Forms.Label lblEgitmenAd;
        private System.Windows.Forms.Label lblEgitmenNo;
        private System.Windows.Forms.Button btnEgitmenOde;
    }
}