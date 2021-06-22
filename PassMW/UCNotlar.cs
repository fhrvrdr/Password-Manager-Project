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

namespace PassMW
{
    public partial class UCNotlar : UserControl
    {
        public UCNotlar()
        {
            InitializeComponent();
            ReloadData();
        }
        private void ReloadData()
        {
            DBPassMWEntities1 dbe = new DBPassMWEntities1();
            int deger = EntityLayer.id;
            var query = from item in dbe.tblNot.Where(p => p.UserID == deger)
                        select item;
            dtgNot.DataSource = query.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtNotAdi.Text=="" || txtNot.Text=="")
            {
                MessageBox.Show("Not Adı veya Not!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DBPassMWEntities1 dB = new DBPassMWEntities1();
                tblNot newNot = new tblNot();
                newNot.NotAdi = txtNotAdi.Text;
                string encNot = AesEncrypt.Encrypt(txtNot.Text);
                newNot.SifreliNot = encNot;
                newNot.UserID = EntityLayer.id;
                dB.tblNot.Add(newNot);
                dB.SaveChanges();
                ReloadData();
                MessageBox.Show("Not Kaydedildi!", "Başarılı");
            }            
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtNot.Text = "";
            txtNotAdi.Text = "";
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
                DBPassMWEntities1 dbe = new DBPassMWEntities1();
                tblNot goster = new tblNot();
            try
            {
                int selected = dtgNot.SelectedCells[0].RowIndex;
                string notAdi = dtgNot.Rows[selected].Cells[1].Value.ToString();
                string SifreNot = dtgNot.Rows[selected].Cells[2].Value.ToString();
                string decnot = AesEncrypt.Decrypt(SifreNot);
                txtNot.Text = decnot;
                txtNotAdi.Text = notAdi;
            }
            catch (Exception)
            {
                MessageBox.Show("Gösterilecek Not Yok!", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }              
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DBPassMWEntities1 dbe = new DBPassMWEntities1();
            tblNot sil = new tblNot();
            try
            {
                int selected = dtgNot.SelectedCells[0].RowIndex;
                int NotId = Convert.ToInt32(dtgNot.Rows[selected].Cells[0].Value);
                dbe.tblNot.Remove(dbe.tblNot.First(x => x.ID == NotId));
                dbe.SaveChanges();
                ReloadData();
            }
            catch (Exception)
            {
                MessageBox.Show("Silinecek Not Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
