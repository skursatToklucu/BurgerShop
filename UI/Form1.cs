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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        Form3 frm;
        public Form1(Form3 frm3)
        {
            frm = frm3;
        }
        public static List<Siparis> siparisler = new List<Siparis>(); // istatistik
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();
        ProjectContext db;
        //public static List<Hamburgerci.DATA.Menu> menuler = new List<Hamburgerci.DATA.Menu>()
        //{
        //    new Hamburgerci.DATA.Menu {MenuAdi = "Big King",Fiyati = 18.25M},
        //    new Hamburgerci.DATA.Menu {MenuAdi = "Double King Chicken",Fiyati = 20.75M},
        //    new Hamburgerci.DATA.Menu {MenuAdi = "Big Royal",Fiyati = 21.25M},
        //    new Hamburgerci.DATA.Menu {MenuAdi = "Whooper",Fiyati = 27.25M},
        //    new Hamburgerci.DATA.Menu {MenuAdi = "Double Whooper",Fiyati = 33.79M},
        //    new Hamburgerci.DATA.Menu {MenuAdi = "Big King XXL",Fiyati = 39.75M}
        //};

        //public static List<Ekstra> Ekstralar = new List<Ekstra>()
        //{
        //    new Ekstra {EkstraAdi ="Ketcap",EkstraFiyat = 0.25M},
        //    new Ekstra {EkstraAdi ="Mayonez",EkstraFiyat = 0.25M},
        //    new Ekstra {EkstraAdi ="Sarımsaklı Mayonez",EkstraFiyat = 0.50M},
        //    new Ekstra {EkstraAdi ="BBQ Sos",EkstraFiyat = 0.75M},
        //    new Ekstra {EkstraAdi ="Hardal",EkstraFiyat = 0.75M},
        //    new Ekstra {EkstraAdi ="Ranch Sos",EkstraFiyat = 0.75M},
        //    new Ekstra {EkstraAdi ="Buffalo Sos",EkstraFiyat = 1M},
        //    new Ekstra {EkstraAdi ="Ballı Hardal ",EkstraFiyat = 1M},
        //};
        private void Form1_Load(object sender, EventArgs e)
        {
            db = new ProjectContext();

            foreach (Hamburgerci.DATA.Menu item in db.menuler)
                cmbMenu.Items.Add(item);

            foreach (Ekstra item in db.ekstraMalzemeler)
                flpEkstraMalzeme.Controls.Add(new CheckBox()
                { Text = item.EkstraAdi, Tag = item });

            foreach (Siparis item in mevcutSiparisler)
                lbxSiparisler.Items.Add(item);

            cmbMenu.SelectedIndex = 0;
            rdoKucuk.Checked = true;

            TutarHesapla();
 

        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelen = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelen.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("C2");

            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            db = new ProjectContext();
            
            Siparis yeniSiparis = new Siparis();
            yeniSiparis.SeciliMenu = (Hamburgerci.DATA.Menu)cmbMenu.SelectedItem;

            if (rdoKucuk.Checked)
                yeniSiparis.MenuBoyutu = rdoKucuk.Text;
            else if (rdoOrta.Checked)
                yeniSiparis.MenuBoyutu = rdoOrta.Text;
            else
                yeniSiparis.MenuBoyutu = rdoBuyuk.Text;

            yeniSiparis.EkstraMalzemeleri = new List<Ekstra>();

            foreach (CheckBox item in flpEkstraMalzeme.Controls)
            {
                if (item.Checked)
                    yeniSiparis.EkstraMalzemeleri.Add((Ekstra)item.Tag);
            }

            yeniSiparis.Adet = (int)nmrAdet.Value;
            yeniSiparis.Hesapla();
            yeniSiparis.SiparisTarihi = DateTime.Now;

            lbxSiparisler.Items.Add(yeniSiparis);
            db.siparisler.Add(yeniSiparis);
            db.SaveChanges();

            //siparisler.Add(yeniSiparis);
            mevcutSiparisler.Add(yeniSiparis);

            TutarHesapla();
        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Siparis Tutarı" + TutarHesapla().ToString("C2") + "\nSatın Alma İşlemini Tamamlamak İster Misiniz","Sipariş Bilgisi", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear();
                mevcutSiparisler.Clear();
                TutarHesapla();
                MessageBox.Show("Sipariş Tamamlandı!","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("İşlem iptal edildi","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
