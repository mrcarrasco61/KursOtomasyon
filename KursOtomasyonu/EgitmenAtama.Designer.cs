
namespace KursOtomasyonu
{
    partial class EgitmenAtama
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgKurs = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgEgitmen = new System.Windows.Forms.DataGridView();
            this.btnAtamaYap = new System.Windows.Forms.Button();
            this.txtEgitmenAdi = new System.Windows.Forms.TextBox();
            this.txtAtananKursId = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dtgAtanan = new System.Windows.Forms.DataGridView();
            this.txtKursId = new System.Windows.Forms.TextBox();
            this.txtEgitmenId = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKurs)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEgitmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAtanan)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgKurs);
            this.panel2.Location = new System.Drawing.Point(776, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 256);
            this.panel2.TabIndex = 13;
            // 
            // dtgKurs
            // 
            this.dtgKurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKurs.Location = new System.Drawing.Point(3, 0);
            this.dtgKurs.Name = "dtgKurs";
            this.dtgKurs.RowHeadersWidth = 51;
            this.dtgKurs.RowTemplate.Height = 24;
            this.dtgKurs.Size = new System.Drawing.Size(606, 253);
            this.dtgKurs.TabIndex = 0;
            this.dtgKurs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKurs_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgEgitmen);
            this.panel1.Location = new System.Drawing.Point(192, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 256);
            this.panel1.TabIndex = 12;
            // 
            // dtgEgitmen
            // 
            this.dtgEgitmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEgitmen.Location = new System.Drawing.Point(0, 0);
            this.dtgEgitmen.Name = "dtgEgitmen";
            this.dtgEgitmen.RowHeadersWidth = 51;
            this.dtgEgitmen.RowTemplate.Height = 24;
            this.dtgEgitmen.Size = new System.Drawing.Size(552, 253);
            this.dtgEgitmen.TabIndex = 0;
            this.dtgEgitmen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEgitmen_CellContentClick);
            // 
            // btnAtamaYap
            // 
            this.btnAtamaYap.Location = new System.Drawing.Point(43, 126);
            this.btnAtamaYap.Name = "btnAtamaYap";
            this.btnAtamaYap.Size = new System.Drawing.Size(98, 40);
            this.btnAtamaYap.TabIndex = 11;
            this.btnAtamaYap.Text = "Egitmen Ata";
            this.btnAtamaYap.UseVisualStyleBackColor = true;
            this.btnAtamaYap.Click += new System.EventHandler(this.btnAtamaYap_Click);
            // 
            // txtEgitmenAdi
            // 
            this.txtEgitmenAdi.Location = new System.Drawing.Point(43, 445);
            this.txtEgitmenAdi.Name = "txtEgitmenAdi";
            this.txtEgitmenAdi.Size = new System.Drawing.Size(126, 22);
            this.txtEgitmenAdi.TabIndex = 18;
            // 
            // txtAtananKursId
            // 
            this.txtAtananKursId.Location = new System.Drawing.Point(43, 399);
            this.txtAtananKursId.Name = "txtAtananKursId";
            this.txtAtananKursId.Size = new System.Drawing.Size(128, 22);
            this.txtAtananKursId.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 50);
            this.button2.TabIndex = 16;
            this.button2.Text = "Atamayı Kaldır";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dtgAtanan
            // 
            this.dtgAtanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAtanan.Location = new System.Drawing.Point(192, 349);
            this.dtgAtanan.Name = "dtgAtanan";
            this.dtgAtanan.RowHeadersWidth = 51;
            this.dtgAtanan.RowTemplate.Height = 24;
            this.dtgAtanan.Size = new System.Drawing.Size(1147, 310);
            this.dtgAtanan.TabIndex = 10;
            this.dtgAtanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAtanan_CellContentClick);
            // 
            // txtKursId
            // 
            this.txtKursId.Location = new System.Drawing.Point(43, 73);
            this.txtKursId.Name = "txtKursId";
            this.txtKursId.Size = new System.Drawing.Size(126, 22);
            this.txtKursId.TabIndex = 15;
            // 
            // txtEgitmenId
            // 
            this.txtEgitmenId.Location = new System.Drawing.Point(43, 27);
            this.txtEgitmenId.Name = "txtEgitmenId";
            this.txtEgitmenId.Size = new System.Drawing.Size(128, 22);
            this.txtEgitmenId.TabIndex = 14;
            // 
            // EgitmenAtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAtamaYap);
            this.Controls.Add(this.txtEgitmenAdi);
            this.Controls.Add(this.txtAtananKursId);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtgAtanan);
            this.Controls.Add(this.txtKursId);
            this.Controls.Add(this.txtEgitmenId);
            this.Name = "EgitmenAtama";
            this.Text = "EgitmenAtama";
            this.Load += new System.EventHandler(this.EgitmenAtama_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKurs)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEgitmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAtanan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgKurs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgEgitmen;
        private System.Windows.Forms.Button btnAtamaYap;
        private System.Windows.Forms.TextBox txtEgitmenAdi;
        private System.Windows.Forms.TextBox txtAtananKursId;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dtgAtanan;
        private System.Windows.Forms.TextBox txtKursId;
        private System.Windows.Forms.TextBox txtEgitmenId;
    }
}