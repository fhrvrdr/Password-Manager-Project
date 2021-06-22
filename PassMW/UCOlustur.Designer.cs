
namespace PassMW
{
    partial class UCOlustur
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOlustur));
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.chkBuyuk = new System.Windows.Forms.CheckBox();
            this.chkSembol = new System.Windows.Forms.CheckBox();
            this.chkSayi = new System.Windows.Forms.CheckBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKopyala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(291, 120);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(445, 34);
            this.txtSifre.TabIndex = 0;
            // 
            // btnOlustur
            // 
            this.btnOlustur.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOlustur.ForeColor = System.Drawing.Color.White;
            this.btnOlustur.Location = new System.Drawing.Point(365, 164);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(135, 36);
            this.btnOlustur.TabIndex = 1;
            this.btnOlustur.Text = "Oluştur";
            this.btnOlustur.UseVisualStyleBackColor = false;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // chkBuyuk
            // 
            this.chkBuyuk.AutoSize = true;
            this.chkBuyuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkBuyuk.Location = new System.Drawing.Point(211, 287);
            this.chkBuyuk.Name = "chkBuyuk";
            this.chkBuyuk.Size = new System.Drawing.Size(150, 33);
            this.chkBuyuk.TabIndex = 2;
            this.chkBuyuk.Text = "Büyük Harf";
            this.chkBuyuk.UseVisualStyleBackColor = true;
            // 
            // chkSembol
            // 
            this.chkSembol.AutoSize = true;
            this.chkSembol.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSembol.Location = new System.Drawing.Point(210, 326);
            this.chkSembol.Name = "chkSembol";
            this.chkSembol.Size = new System.Drawing.Size(119, 33);
            this.chkSembol.TabIndex = 3;
            this.chkSembol.Text = "Sembol";
            this.chkSembol.UseVisualStyleBackColor = true;
            // 
            // chkSayi
            // 
            this.chkSayi.AutoSize = true;
            this.chkSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkSayi.Location = new System.Drawing.Point(209, 365);
            this.chkSayi.Name = "chkSayi";
            this.chkSayi.Size = new System.Drawing.Size(81, 33);
            this.chkSayi.TabIndex = 4;
            this.chkSayi.Text = "Sayı";
            this.chkSayi.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            this.trackBar1.LargeChange = 1;
            this.trackBar1.Location = new System.Drawing.Point(386, 234);
            this.trackBar1.Maximum = 24;
            this.trackBar1.Minimum = 12;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(350, 56);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(206, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Uzunluk(12-24)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(442, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifre Oluşturucu";
            // 
            // btnKopyala
            // 
            this.btnKopyala.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKopyala.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKopyala.ForeColor = System.Drawing.Color.White;
            this.btnKopyala.Location = new System.Drawing.Point(506, 164);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(135, 36);
            this.btnKopyala.TabIndex = 9;
            this.btnKopyala.Text = "Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = false;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // UCOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.chkSayi);
            this.Controls.Add(this.chkSembol);
            this.Controls.Add(this.chkBuyuk);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.txtSifre);
            this.Name = "UCOlustur";
            this.Size = new System.Drawing.Size(971, 449);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.CheckBox chkBuyuk;
        private System.Windows.Forms.CheckBox chkSembol;
        private System.Windows.Forms.CheckBox chkSayi;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKopyala;
    }
}
