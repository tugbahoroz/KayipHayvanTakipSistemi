namespace KayipHayvanTakipSistemi
{
    partial class Form1
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
            this.lblHayvanAd = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblCins = new System.Windows.Forms.Label();
            this.lblYas = new System.Windows.Forms.Label();
            this.lblSahipAd = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtHayvanAd = new System.Windows.Forms.TextBox();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtCins = new System.Windows.Forms.TextBox();
            this.txtYas = new System.Windows.Forms.TextBox();
            this.txtSahipAd = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnIlanEkle = new System.Windows.Forms.Button();
            this.lstIlanlar = new System.Windows.Forms.ListBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblHayvanAd
            // 
            this.lblHayvanAd.AutoSize = true;
            this.lblHayvanAd.Location = new System.Drawing.Point(35, 9);
            this.lblHayvanAd.Name = "lblHayvanAd";
            this.lblHayvanAd.Size = new System.Drawing.Size(83, 16);
            this.lblHayvanAd.TabIndex = 0;
            this.lblHayvanAd.Text = "Hayvan Adı :";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(35, 37);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(90, 16);
            this.lblTur.TabIndex = 1;
            this.lblTur.Text = "Hayvan Türü :";
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Location = new System.Drawing.Point(35, 66);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(92, 16);
            this.lblCins.TabIndex = 2;
            this.lblCins.Text = "Hayvan Cinsi :";
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(35, 95);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(90, 16);
            this.lblYas.TabIndex = 3;
            this.lblYas.Text = "Hayvan Yaşı :";
            // 
            // lblSahipAd
            // 
            this.lblSahipAd.AutoSize = true;
            this.lblSahipAd.Location = new System.Drawing.Point(35, 150);
            this.lblSahipAd.Name = "lblSahipAd";
            this.lblSahipAd.Size = new System.Drawing.Size(71, 16);
            this.lblSahipAd.TabIndex = 4;
            this.lblSahipAd.Text = "Sahip Adı :";
            this.lblSahipAd.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(35, 180);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(59, 16);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon :";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(35, 212);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(84, 16);
            this.lblTarih.TabIndex = 6;
            this.lblTarih.Text = "Kayıp Tarihi :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(35, 261);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(69, 16);
            this.lblAciklama.TabIndex = 7;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // txtHayvanAd
            // 
            this.txtHayvanAd.Location = new System.Drawing.Point(137, 6);
            this.txtHayvanAd.Name = "txtHayvanAd";
            this.txtHayvanAd.Size = new System.Drawing.Size(229, 22);
            this.txtHayvanAd.TabIndex = 8;
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(137, 34);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(229, 22);
            this.txtTur.TabIndex = 9;
            this.txtTur.TextChanged += new System.EventHandler(this.txtTur_TextChanged);
            // 
            // txtCins
            // 
            this.txtCins.Location = new System.Drawing.Point(137, 63);
            this.txtCins.Name = "txtCins";
            this.txtCins.Size = new System.Drawing.Size(229, 22);
            this.txtCins.TabIndex = 10;
            // 
            // txtYas
            // 
            this.txtYas.Location = new System.Drawing.Point(137, 92);
            this.txtYas.Name = "txtYas";
            this.txtYas.Size = new System.Drawing.Size(229, 22);
            this.txtYas.TabIndex = 11;
            // 
            // txtSahipAd
            // 
            this.txtSahipAd.Location = new System.Drawing.Point(137, 147);
            this.txtSahipAd.Name = "txtSahipAd";
            this.txtSahipAd.Size = new System.Drawing.Size(229, 22);
            this.txtSahipAd.TabIndex = 12;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(137, 177);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(229, 22);
            this.txtTelefon.TabIndex = 13;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(137, 237);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(687, 104);
            this.txtAciklama.TabIndex = 15;
            // 
            // btnIlanEkle
            // 
            this.btnIlanEkle.Location = new System.Drawing.Point(38, 343);
            this.btnIlanEkle.Name = "btnIlanEkle";
            this.btnIlanEkle.Size = new System.Drawing.Size(75, 23);
            this.btnIlanEkle.TabIndex = 16;
            this.btnIlanEkle.Text = "İlan Ekle :";
            this.btnIlanEkle.UseVisualStyleBackColor = true;
            this.btnIlanEkle.Click += new System.EventHandler(this.btnIlanEkle_Click);
            // 
            // lstIlanlar
            // 
            this.lstIlanlar.FormattingEnabled = true;
            this.lstIlanlar.ItemHeight = 16;
            this.lstIlanlar.Location = new System.Drawing.Point(38, 373);
            this.lstIlanlar.Name = "lstIlanlar";
            this.lstIlanlar.Size = new System.Drawing.Size(998, 228);
            this.lstIlanlar.TabIndex = 17;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(137, 207);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 22);
            this.dtpTarih.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 613);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lstIlanlar);
            this.Controls.Add(this.btnIlanEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSahipAd);
            this.Controls.Add(this.txtYas);
            this.Controls.Add(this.txtCins);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.txtHayvanAd);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSahipAd);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.lblCins);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblHayvanAd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHayvanAd;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.Label lblSahipAd;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtHayvanAd;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtCins;
        private System.Windows.Forms.TextBox txtYas;
        private System.Windows.Forms.TextBox txtSahipAd;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnIlanEkle;
        private System.Windows.Forms.ListBox lstIlanlar;
        private System.Windows.Forms.DateTimePicker dtpTarih;
    }
}

