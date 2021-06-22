
namespace PassMW
{
    partial class FormGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            this.lblGiris = new System.Windows.Forms.Label();
            this.checkGirisSifre = new System.Windows.Forms.CheckBox();
            this.GirisLogo = new System.Windows.Forms.PictureBox();
            this.txtGirisMail = new System.Windows.Forms.TextBox();
            this.txtGirisSifre = new System.Windows.Forms.TextBox();
            this.lblGirisSifre = new System.Windows.Forms.Label();
            this.lblGirisMail = new System.Windows.Forms.Label();
            this.btnKayıtYonlendir = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GirisLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGiris
            // 
            this.lblGiris.AutoSize = true;
            this.lblGiris.BackColor = System.Drawing.Color.White;
            this.lblGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGiris.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblGiris.Location = new System.Drawing.Point(163, 74);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(132, 32);
            this.lblGiris.TabIndex = 26;
            this.lblGiris.Text = "Giriş Yap";
            // 
            // checkGirisSifre
            // 
            this.checkGirisSifre.AutoSize = true;
            this.checkGirisSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkGirisSifre.Location = new System.Drawing.Point(147, 252);
            this.checkGirisSifre.Name = "checkGirisSifre";
            this.checkGirisSifre.Size = new System.Drawing.Size(134, 24);
            this.checkGirisSifre.TabIndex = 25;
            this.checkGirisSifre.Text = "Şifreyi Göster";
            this.checkGirisSifre.UseVisualStyleBackColor = true;
            this.checkGirisSifre.CheckedChanged += new System.EventHandler(this.checkGirisSifre_CheckedChanged);
            // 
            // GirisLogo
            // 
            this.GirisLogo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.GirisLogo.Image = ((System.Drawing.Image)(resources.GetObject("GirisLogo.Image")));
            this.GirisLogo.Location = new System.Drawing.Point(17, 52);
            this.GirisLogo.Name = "GirisLogo";
            this.GirisLogo.Size = new System.Drawing.Size(70, 75);
            this.GirisLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GirisLogo.TabIndex = 24;
            this.GirisLogo.TabStop = false;
            // 
            // txtGirisMail
            // 
            this.txtGirisMail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtGirisMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisMail.Location = new System.Drawing.Point(147, 157);
            this.txtGirisMail.Name = "txtGirisMail";
            this.txtGirisMail.Size = new System.Drawing.Size(201, 30);
            this.txtGirisMail.TabIndex = 21;
            // 
            // txtGirisSifre
            // 
            this.txtGirisSifre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtGirisSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGirisSifre.Location = new System.Drawing.Point(147, 205);
            this.txtGirisSifre.MaxLength = 32;
            this.txtGirisSifre.Name = "txtGirisSifre";
            this.txtGirisSifre.PasswordChar = '•';
            this.txtGirisSifre.Size = new System.Drawing.Size(201, 30);
            this.txtGirisSifre.TabIndex = 20;
            // 
            // lblGirisSifre
            // 
            this.lblGirisSifre.AutoSize = true;
            this.lblGirisSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisSifre.Location = new System.Drawing.Point(12, 208);
            this.lblGirisSifre.Name = "lblGirisSifre";
            this.lblGirisSifre.Size = new System.Drawing.Size(52, 25);
            this.lblGirisSifre.TabIndex = 19;
            this.lblGirisSifre.Text = "Şifre";
            // 
            // lblGirisMail
            // 
            this.lblGirisMail.AutoSize = true;
            this.lblGirisMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisMail.Location = new System.Drawing.Point(12, 157);
            this.lblGirisMail.Name = "lblGirisMail";
            this.lblGirisMail.Size = new System.Drawing.Size(68, 25);
            this.lblGirisMail.TabIndex = 18;
            this.lblGirisMail.Text = "E-Mail";
            // 
            // btnKayıtYonlendir
            // 
            this.btnKayıtYonlendir.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKayıtYonlendir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıtYonlendir.ForeColor = System.Drawing.Color.White;
            this.btnKayıtYonlendir.Location = new System.Drawing.Point(103, 384);
            this.btnKayıtYonlendir.Name = "btnKayıtYonlendir";
            this.btnKayıtYonlendir.Size = new System.Drawing.Size(192, 47);
            this.btnKayıtYonlendir.TabIndex = 15;
            this.btnKayıtYonlendir.Text = "Kayıt Ol";
            this.btnKayıtYonlendir.UseVisualStyleBackColor = false;
            this.btnKayıtYonlendir.Click += new System.EventHandler(this.btnYönlendir_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.White;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btnGiris.Location = new System.Drawing.Point(103, 318);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(192, 47);
            this.btnGiris.TabIndex = 27;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(336, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(47, 26);
            this.btnKapat.TabIndex = 28;
            this.btnKapat.Text = "X";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 470);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lblGiris);
            this.Controls.Add(this.checkGirisSifre);
            this.Controls.Add(this.GirisLogo);
            this.Controls.Add(this.txtGirisMail);
            this.Controls.Add(this.txtGirisSifre);
            this.Controls.Add(this.lblGirisSifre);
            this.Controls.Add(this.lblGirisMail);
            this.Controls.Add(this.btnKayıtYonlendir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)(this.GirisLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.CheckBox checkGirisSifre;
        private System.Windows.Forms.PictureBox GirisLogo;
        private System.Windows.Forms.TextBox txtGirisMail;
        private System.Windows.Forms.TextBox txtGirisSifre;
        private System.Windows.Forms.Label lblGirisSifre;
        private System.Windows.Forms.Label lblGirisMail;
        private System.Windows.Forms.Button btnKayıtYonlendir;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKapat;
    }
}