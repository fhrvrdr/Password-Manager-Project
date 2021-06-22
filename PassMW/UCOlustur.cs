using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassMW
{
    public partial class UCOlustur : UserControl
    {
        public UCOlustur()
        {
            InitializeComponent();
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            string BuyukHarf = "QWERTYUOPASDFGHJKLİZXCVBNM";
            string KucukHarf = "qwertyuopasdfghjklizxcvbnm";
            string Sembol = "!%&/()=?_-£#${[]}*";
            string Sayi = "1234567890";
            if (chkSembol.Checked)
            {
                KucukHarf += Sembol;
            }
            if (chkSayi.Checked)
            {
                KucukHarf += Sayi;
            }
            if (chkBuyuk.Checked)
            {
                KucukHarf += BuyukHarf;
            }
            StringBuilder password = new StringBuilder();
            Random rnd = new Random();
            int passwordLength = trackBar1.Value;
            while (passwordLength-- > 0)
            {
                password.Append(KucukHarf[rnd.Next(KucukHarf.Length)]);
            }
            txtSifre.Text = password.ToString();
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtSifre.Text);
                MessageBox.Show("Şifre Kopyalandı!", "Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Kopyalanacak Veri Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
