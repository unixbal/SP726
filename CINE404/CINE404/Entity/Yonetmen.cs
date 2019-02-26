using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE404
{
    public class Yonetmen
    {
        public int YonetmenID { get; set; }
        public string YonetmenAdSoyad { get; set; }
        public ICollection<Film> FilmYonetmen { get; set; }
    }
}
