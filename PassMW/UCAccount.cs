using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AesSifre;

namespace PassMW
{
    public partial class UCAccount : UserControl
    {
        public UCAccount()
        {
            InitializeComponent();
            ReloadData();
        }
        private void ReloadData()
        {
            DBPassMWEntities1 dbe = new DBPassMWEntities1();
            int deger = EntityLayer.id;
            var query = from item in dbe.tbl_Acc.Where(p => p.UserID == deger) 
                        select item;
            dtgAccounts.DataSource = query.ToList();
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            DBPassMWEntities1 dbe = new DBPassMWEntities1();
            tbl_Acc goster = new tbl_Acc();
            try
            {
                int selected = dtgAccounts.SelectedCells[0].RowIndex;
                string username = dtgAccounts.Rows[selected].Cells[3].Value.ToString();
                string password = dtgAccounts.Rows[selected].Cells[4].Value.ToString();
                string decusr = AesEncrypt.Decrypt(username);
                string decpass = AesEncrypt.Decrypt(password);
                txtKullanici.Text = decusr;
                txtSifre.Text = decpass;
            }
            catch (Exception)
            {
                MessageBox.Show("Gösterilecek Hesap Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DBPassMWEntities1 dbe = new DBPassMWEntities1();
                tbl_Acc deleteacc = new tbl_Acc();
                int selected = dtgAccounts.SelectedCells[0].RowIndex;
                int username = Convert.ToInt32(dtgAccounts.Rows[selected].Cells[0].Value);
                dbe.tbl_Acc.Remove(dbe.tbl_Acc.First(x => x.ID == username));
                dbe.SaveChanges();
                ReloadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Hesap Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetText(txtSifre.Text);
                MessageBox.Show("Şifre Kopyalandı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Kopyalanacak Veri Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
