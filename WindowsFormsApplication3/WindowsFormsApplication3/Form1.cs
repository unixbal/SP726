using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model1 ctx = new Model1();
            Kurs k1 = new Kurs();
            k1.KursAdi = "SmartPro Yazılım";
            k1.KursAdresi = "Kadıköy";
            


            Ogrenci o1 = new Ogrenci();
            
            o1.KursOgrenci=k1;
            //v1.Ogrenciler.Add(o1);

            ctx.Ogrencis.Add(o1);
            ctx.Kurss.Add(k1);
            ctx.SaveChanges();
        }
    }
}
