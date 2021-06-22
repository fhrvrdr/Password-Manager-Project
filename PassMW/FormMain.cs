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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void btnHesaplar_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UCAccount uca = new UCAccount();
            uca.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uca);
        }
        private void btnUret_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UCOlustur uco = new UCOlustur();
            uco.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uco);
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UCEkle uce = new UCEkle();
            uce.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uce);
        }
        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
            UCAccount uca = new UCAccount();
            uca.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uca);
        }
        private void btnNotlar_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            UCNotlar uce = new UCNotlar();
            uce.Dock = DockStyle.Fill;
            panelMain.Controls.Add(uce);
        }
    }
}
