using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE404
{
    public class Film
    {
        public int FilmID { get; set; }

        
        public int YonetmenID { get; set; }
        public Yonetmen YonetmenFK { get; set; }



        [Required]
        public string FilmAd { get; set; }
        public ICollection<Oyuncu> Oyuncus { get; set; }


        [Timestamp]
        public byte[] FilmSonDegisiklik { get; set; }
    }
}
