using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class Kurs
    {
        public int KursID { get; set; }
        public string KursAdi { get; set; }
        public string KursAdresi { get; set; }
        public ICollection<Ogrenci> Ogrencis { get; set; }
    }
}
