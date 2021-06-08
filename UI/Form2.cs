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
    public partial class Form2 : Form
    {

        public Form2()
        {

            InitializeComponent();
        }
        ProjectContext db;
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            db = new ProjectContext();

            db.menuler.Add(new Hamburgerci.DATA.Menu { MenuAdi = txtMenuAdi.Text, Fiyati = nmrMenuFiyat.Value });
            db.SaveChanges();

            Metod.Temizle(this.Controls);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
