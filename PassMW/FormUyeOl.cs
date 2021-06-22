using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassMW
{
    public partial class FormUyeOl : Form
    {
        public FormUyeOl()
        {
            InitializeComponent();
        }
        DBPassMWEntities1 dbe = new DBPassMWEntities1();
        private void button1_Click(object sender, EventArgs e)
        {
            if (txtKulAdi.Text == "" || txtUyeMail.Text == "" || txtUyeSifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı , şifre ve mail kısmında boş alan var.", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dbe.tblUye.Any(uye => uye.email == txtUyeMail.Text))
                
                { 
                    MessageBox.Show("Mail mevcut!", "Kayıt Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    tblUye newUye = new tblUye();
                    newUye.email = txtUyeMail.Text;
                    newUye.password = txtUyeSifre.Text;
                    newUye.username = txtKulAdi.Text;
                    dbe.tblUye.Add(newUye);
                    dbe.SaveChanges();
                    MessageBox.Show("Başarıyla Kayıt edildi!");
                }
            }
        }
        private void checkSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUyeSifre.Checked)
            {
                txtUyeSifre.PasswordChar = '\0';
            }
            else
            {
                txtUyeSifre.PasswordChar = '•';
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
