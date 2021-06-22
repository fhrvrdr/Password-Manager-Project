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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnYönlendir_Click(object sender, EventArgs e)
        {

            Hide();
            using (FormUyeOl form2 = new FormUyeOl())
                form2.ShowDialog();
            Show();

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkGirisSifre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkGirisSifre.Checked)
            {
                txtGirisSifre.PasswordChar = '\0';
            }
            else
            {
                txtGirisSifre.PasswordChar = '•';
            }
        }
        DBPassMWEntities1 dbe = new DBPassMWEntities1();
        private void btnGiris_Click(object sender, EventArgs e)
        {

                var eslesti = dbe.tblUye.FirstOrDefault(uye => uye.email == txtGirisMail.Text && uye.password == txtGirisSifre.Text);
                if (eslesti!=null)
                {
                    new FormMain().Show();
                    EntityLayer.id = eslesti.ID;
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            
        }
    }
}
