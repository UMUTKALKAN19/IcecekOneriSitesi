using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Models
{
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        [Required(ErrorMessage ="Kategori adı boş geçilemez!")]
        [StringLength(30,ErrorMessage ="2-30 arası girin",MinimumLength =2)]
        public string KategoriAd { get; set; }
        public string KategoriAciklama { get; set; }
        public int KategoriAdet { get; set; }
        public bool KategoriDurum { get; set; }

        public List<Icecek> Icecekler { get; set; }
    }
}
