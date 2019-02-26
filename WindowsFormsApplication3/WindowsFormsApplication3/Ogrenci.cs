using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        public int KursID { get; set; }
        public Kurs KursOgrenci { get; set; }
    }
}
