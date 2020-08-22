namespace UyelikCalisanTakip
{
    partial class frmUyelik
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
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.btn_Kayit = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTC = new System.Windows.Forms.Label();
            this.dtwUyelikTablo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtwUyelikTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(32, 62);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(151, 41);
            this.btnCalisanEkle.TabIndex = 52;
            this.btnCalisanEkle.Text = "Calısan Bilgisi";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(369, 320);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 51;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(259, 320);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 50;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(152, 320);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 49;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(213, 253);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(199, 22);
            this.txtMail.TabIndex = 47;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(213, 219);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(199, 22);
            this.txtTelefon.TabIndex = 46;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(213, 182);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(199, 22);
            this.txtSoyad.TabIndex = 48;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(213, 154);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(199, 22);
            this.txtAd.TabIndex = 45;
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(213, 126);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(199, 22);
            this.txtTC.TabIndex = 44;
            // 
            // btn_Kayit
            // 
            this.btn_Kayit.Location = new System.Drawing.Point(17, 320);
            this.btn_Kayit.Name = "btn_Kayit";
            this.btn_Kayit.Size = new System.Drawing.Size(109, 23);
            this.btn_Kayit.TabIndex = 43;
            this.btn_Kayit.Text = "Kayıt";
            this.btn_Kayit.UseVisualStyleBackColor = true;
            this.btn_Kayit.Click += new System.EventHandler(this.btn_Kayit_Click);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(29, 258);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(51, 17);
            this.lblMail.TabIndex = 42;
            this.lblMail.Text = "E-Mail:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(24, 224);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(124, 17);
            this.lblTelefon.TabIndex = 41;
            this.lblTelefon.Text = "Telefon Numarası:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(24, 187);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(56, 17);
            this.lblSoyad.TabIndex = 40;
            this.lblSoyad.Text = "Soyad :";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(29, 159);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(29, 17);
            this.lblAd.TabIndex = 39;
            this.lblAd.Text = "Ad:";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(24, 129);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(138, 17);
            this.lblTC.TabIndex = 38;
            this.lblTC.Text = "TC Kimlik Numarası: ";
            // 
            // dtwUyelikTablo
            // 
            this.dtwUyelikTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwUyelikTablo.Location = new System.Drawing.Point(448, 62);
            this.dtwUyelikTablo.Name = "dtwUyelikTablo";
            this.dtwUyelikTablo.RowHeadersWidth = 51;
            this.dtwUyelikTablo.RowTemplate.Height = 24;
            this.dtwUyelikTablo.Size = new System.Drawing.Size(526, 254);
            this.dtwUyelikTablo.TabIndex = 53;
            this.dtwUyelikTablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwUyelikTablo_CellContentClick);
            // 
            // frmUyelik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 412);
            this.Controls.Add(this.dtwUyelikTablo);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.btn_Kayit);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.lblTC);
            this.Name = "frmUyelik";
            this.Text = "Üyelik Bilgisi Ekleme Formu";
            this.Load += new System.EventHandler(this.frmUyelik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtwUyelikTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Button btn_Kayit;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.DataGridView dtwUyelikTablo;
    }
}

