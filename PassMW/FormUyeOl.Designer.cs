
namespace PassMW
{
    partial class FormUyeOl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUyeOl));
            this.btnUyeOl = new System.Windows.Forms.Button();
            this.lblKulAdi = new System.Windows.Forms.Label();
            this.txtKulAdi = new System.Windows.Forms.TextBox();
            this.lblUyeMail = new System.Windows.Forms.Label();
            this.lblUyeSifre = new System.Windows.Forms.Label();
            this.txtUyeSifre = new System.Windows.Forms.TextBox();
            this.txtUyeMail = new System.Windows.Forms.TextBox();
            this.uyeOlLogo = new System.Windows.Forms.PictureBox();
            this.checkUyeSifre = new System.Windows.Forms.CheckBox();
            this.lblKayıt = new System.Windows.Forms.Label();
            this.lblGirisDon = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.uyeOlLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUyeOl
            // 
            this.btnUyeOl.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnUyeOl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeOl.ForeColor = System.Drawing.Color.White;
            this.btnUyeOl.Location = new System.Drawing.Point(111, 348);
            this.btnUyeOl.Name = "btnUyeOl";
            this.btnUyeOl.Size = new System.Drawing.Size(192, 47);
            this.btnUyeOl.TabIndex = 0;
            this.btnUyeOl.Text = "Kayıt Ol";
            this.btnUyeOl.UseVisualStyleBackColor = false;
            this.btnUyeOl.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblKulAdi
            // 
            this.lblKulAdi.AutoSize = true;
            this.lblKulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKulAdi.Location = new System.Drawing.Point(34, 137);
            this.lblKulAdi.Name = "lblKulAdi";
            this.lblKulAdi.Size = new System.Drawing.Size(66, 25);
            this.lblKulAdi.TabIndex = 1;
            this.lblKulAdi.Text = "Adınız";
            // 
            // txtKulAdi
            // 
            this.txtKulAdi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtKulAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKulAdi.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtKulAdi.Location = new System.Drawing.Point(169, 132);
            this.txtKulAdi.Name = "txtKulAdi";
            this.txtKulAdi.Size = new System.Drawing.Size(201, 30);
            this.txtKulAdi.TabIndex = 2;
            // 
            // lblUyeMail
            // 
            this.lblUyeMail.AutoSize = true;
            this.lblUyeMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeMail.Location = new System.Drawing.Point(34, 180);
            this.lblUyeMail.Name = "lblUyeMail";
            this.lblUyeMail.Size = new System.Drawing.Size(68, 25);
            this.lblUyeMail.TabIndex = 3;
            this.lblUyeMail.Text = "E-Mail";
            // 
            // lblUyeSifre
            // 
            this.lblUyeSifre.AutoSize = true;
            this.lblUyeSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeSifre.Location = new System.Drawing.Point(34, 231);
            this.lblUyeSifre.Name = "lblUyeSifre";
            this.lblUyeSifre.Size = new System.Drawing.Size(52, 25);
            this.lblUyeSifre.TabIndex = 4;
            this.lblUyeSifre.Text = "Şifre";
            // 
            // txtUyeSifre
            // 
            this.txtUyeSifre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUyeSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeSifre.Location = new System.Drawing.Point(169, 228);
            this.txtUyeSifre.MaxLength = 32;
            this.txtUyeSifre.Name = "txtUyeSifre";
            this.txtUyeSifre.PasswordChar = '•';
            this.txtUyeSifre.Size = new System.Drawing.Size(201, 30);
            this.txtUyeSifre.TabIndex = 6;
            // 
            // txtUyeMail
            // 
            this.txtUyeMail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUyeMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUyeMail.Location = new System.Drawing.Point(169, 180);
            this.txtUyeMail.Name = "txtUyeMail";
            this.txtUyeMail.Size = new System.Drawing.Size(201, 30);
            this.txtUyeMail.TabIndex = 7;
            // 
            // uyeOlLogo
            // 
            this.uyeOlLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.uyeOlLogo.Image = ((System.Drawing.Image)(resources.GetObject("uyeOlLogo.Image")));
            this.uyeOlLogo.Location = new System.Drawing.Point(39, 27);
            this.uyeOlLogo.Name = "uyeOlLogo";
            this.uyeOlLogo.Size = new System.Drawing.Size(70, 75);
            this.uyeOlLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uyeOlLogo.TabIndex = 11;
            this.uyeOlLogo.TabStop = false;
            // 
            // checkUyeSifre
            // 
            this.checkUyeSifre.AutoSize = true;
            this.checkUyeSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkUyeSifre.Location = new System.Drawing.Point(169, 275);
            this.checkUyeSifre.Name = "checkUyeSifre";
            this.checkUyeSifre.Size = new System.Drawing.Size(134, 24);
            this.checkUyeSifre.TabIndex = 12;
            this.checkUyeSifre.Text = "Şifreyi Göster";
            this.checkUyeSifre.UseVisualStyleBackColor = true;
            this.checkUyeSifre.CheckedChanged += new System.EventHandler(this.checkSifre_CheckedChanged);
            // 
            // lblKayıt
            // 
            this.lblKayıt.AutoSize = true;
            this.lblKayıt.BackColor = System.Drawing.Color.White;
            this.lblKayıt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayıt.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblKayıt.Location = new System.Drawing.Point(190, 49);
            this.lblKayıt.Name = "lblKayıt";
            this.lblKayıt.Size = new System.Drawing.Size(141, 32);
            this.lblKayıt.TabIndex = 13;
            this.lblKayıt.Text = "KAYIT OL";
            // 
            // lblGirisDon
            // 
            this.lblGirisDon.AutoSize = true;
            this.lblGirisDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisDon.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lblGirisDon.Location = new System.Drawing.Point(118, 417);
            this.lblGirisDon.Name = "lblGirisDon";
            this.lblGirisDon.Size = new System.Drawing.Size(174, 25);
            this.lblGirisDon.TabIndex = 14;
            this.lblGirisDon.TabStop = true;
            this.lblGirisDon.Text = "Giriş Ekranına Dön";
            this.lblGirisDon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormUyeOl
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 506);
            this.Controls.Add(this.lblGirisDon);
            this.Controls.Add(this.lblKayıt);
            this.Controls.Add(this.checkUyeSifre);
            this.Controls.Add(this.uyeOlLogo);
            this.Controls.Add(this.txtUyeMail);
            this.Controls.Add(this.txtUyeSifre);
            this.Controls.Add(this.lblUyeSifre);
            this.Controls.Add(this.lblUyeMail);
            this.Controls.Add(this.txtKulAdi);
            this.Controls.Add(this.lblKulAdi);
            this.Controls.Add(this.btnUyeOl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUyeOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ol";
            ((System.ComponentModel.ISupportInitialize)(this.uyeOlLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUyeOl;
        private System.Windows.Forms.Label lblKulAdi;
        private System.Windows.Forms.TextBox txtKulAdi;
        private System.Windows.Forms.Label lblUyeMail;
        private System.Windows.Forms.Label lblUyeSifre;
        private System.Windows.Forms.TextBox txtUyeSifre;
        private System.Windows.Forms.TextBox txtUyeMail;
        private System.Windows.Forms.PictureBox uyeOlLogo;
        private System.Windows.Forms.CheckBox checkUyeSifre;
        private System.Windows.Forms.Label lblKayıt;
        private System.Windows.Forms.LinkLabel lblGirisDon;
    }
}

