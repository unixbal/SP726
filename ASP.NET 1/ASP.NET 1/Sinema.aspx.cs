using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_1
{
    public partial class Sinema : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TabloGuncelle();
        }

        private void TabloGuncelle()
        {
            SINEMAEntities ctx = new SINEMAEntities();
            DataList_Filmler.DataSource = ctx.Films.ToList();
            DataList_Filmler.DataBind();
        }

        protected void btn_FilmKaydet_Click(object sender, EventArgs e)
        {
            Film f1 = new Film();
            f1.FilmAdi = txt_FilmAd.Text;
            f1.FilmFragmanLink = txt_FilmFragman.Text;
            f1.FilmKisaBilgi = txt_FilmKisaBilgi.Text;

            SINEMAEntities ctx = new SINEMAEntities();
            ctx.Films.Add(f1);
            ctx.SaveChanges();
            TabloGuncelle();
        }
    }
}