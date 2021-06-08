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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        ProjectContext db;
        private void grpEkstraMalzemeEkle_Enter(object sender, EventArgs e)
        {
            db = new ProjectContext();
            db.ekstraMalzemeler.Add(new Hamburgerci.DATA.Ekstra { EkstraAdi = txtEkstraMalzemeAdi.Text, EkstraFiyat = nmrEkstraMalzemeFiyat.Value });
            db.SaveChanges();
            Metod.Temizle(this.Controls);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
