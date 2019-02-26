using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CINE404
{
    [Table("Oyuncular")]
    public class Oyuncu
    {


        public int OyuncuID { get; set; }


        [Index("INDEX_OyuncuAdSoyad", IsClustered = false, IsUnique = false)]
        [MaxLength(30)]
        public string OyuncuAdSoyad { get; set; }

        public DateTime? OyuncuDogumTarihi { get; set; }
        public Film OyuncuFilm { get; set; }
    }
}
