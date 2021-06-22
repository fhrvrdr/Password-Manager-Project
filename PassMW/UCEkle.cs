using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AesSifre;
using System.Security.Cryptography;

namespace PassMW
{
    public partial class UCEkle : UserControl
    {
        public UCEkle()
        {
            InitializeComponent();
        }
        private void chkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtSifre.PasswordChar = '\0';
            }
            else
            {
                txtSifre.PasswordChar = '•';
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAccount.Text = "";
            txtSifre.Text = "";
            txtUsername.Text = "";
            cmbHesapTuru.SelectedItem = null;
            chkShow.Checked = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbHesapTuru.SelectedItem==null || txtAccount.Text=="" )
            {
                MessageBox.Show("Hesap Türü veya Hesap Adı Boş!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBPassMWEntities1 dB = new DBPassMWEntities1();
                tbl_Acc newAccount = new tbl_Acc();
                newAccount.AccountType = cmbHesapTuru.SelectedItem.ToString();
                newAccount.AccountName = txtAccount.Text;
                string username= AesEncrypt.Encrypt(txtUsername.Text).ToString();
                string password = AesEncrypt.Encrypt(txtSifre.Text).ToString();
                newAccount.AccUsername = username;
                newAccount.AccPass= password;
                newAccount.UserID = EntityLayer.id;
                dB.tbl_Acc.Add(newAccount);
                dB.SaveChanges();
                MessageBox.Show("Hesap Kaydedildi!", "Başarılı");
            }
        }
    }
}
