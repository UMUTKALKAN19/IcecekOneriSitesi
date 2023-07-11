using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Models
{
    public class Mesajlar
    {
        [Key]
        public int MesajID { get; set; }
        [Required(ErrorMessage = "Gönderen adı boş geçilemez!")]
        [StringLength(30, ErrorMessage = "2-30 arası karakter girin", MinimumLength = 2)]
        public string MesajGonderen { get; set; }
        [Required(ErrorMessage = "Başlık boş geçilemez!")]
        [StringLength(50, ErrorMessage = "2-50 arası karakter girin", MinimumLength = 2)]
        public string MesajBaslik { get; set; }
        [Required(ErrorMessage = "Mail boş geçilemez!")]
        [StringLength(50, ErrorMessage = "2-50 arası karakter girin", MinimumLength = 2)]
        public string MesajMail { get; set; }
        [Required(ErrorMessage = "İçerik boş geçilemez!")]
        [StringLength(300, ErrorMessage = "2-300 arası karakter girin", MinimumLength = 2)]
        public string MesajIcerik { get; set; }
        public DateTime MesajTarih
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

    }
}
