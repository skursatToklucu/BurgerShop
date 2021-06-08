using Hamburgerci.DAL.Context;
using Hamburgerci.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        ProjectContext db;
        private void Form4_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();

            decimal deger = 0;
            int ToplamAdet = 0;
            decimal ekstraMalzemeGeliri = 0;
            foreach (Siparis item in db.siparisler)
            {
                lbxTumSiparisler.Items.Add(item);
                deger += item.ToplamTutar;
                ToplamAdet += item.Adet;

                foreach (Ekstra ekstra in item.EkstraMalzemeleri)
                    ekstraMalzemeGeliri += ekstra.EkstraFiyat;

            }

            lblCiro.Text = deger.ToString("C2");
            lblEkstraMalzemeGeliri.Text = ekstraMalzemeGeliri.ToString();
            lblSatilanUrunAdedi.Text = ToplamAdet.ToString();
            lblToplamSiparisSayisi.Text = Form1.siparisler.Count.ToString();


        }
    }
}
