using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Models
{
    public class Yorum
    {
        [Key]
        public int YorumID { get; set; }
        [Required(ErrorMessage = "Gönderen adı boş geçilemez!")]
        [StringLength(30, ErrorMessage = "2-30 arası karakter girin", MinimumLength = 2)]
        public string YorumSahip { get; set; }
        [Required(ErrorMessage = "Mail boş geçilemez!")]
        [StringLength(50, ErrorMessage = "2-50 arası karakter girin", MinimumLength = 2)]
        public string YorumMail { get; set; }
        public DateTime YorumTarih
        {
            get
            {
                return this.dateCreated.HasValue
                   ? this.dateCreated.Value
                   : DateTime.Now;
            }

            set { this.dateCreated = value; }
        }
        private DateTime? dateCreated = null;
        public bool YorumOnay { get; set; }
        [Required(ErrorMessage = "Yorum boş geçilemez!")]
        [StringLength(300, ErrorMessage = "2-300 arası karakter girin", MinimumLength = 2)]
        public string YorumIcerik { get; set; }

        public int IcecekID { get; set; }
        public Icecek Icecek { get; set; }
    }
}
