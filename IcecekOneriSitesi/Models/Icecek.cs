using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace IcecekOneriSitesi.Models
{
    public class Icecek
    {
        [Key]
        public int IcecekID { get; set; }
        
        public string IcecekAd { get; set; }


        public string IcecekMalzeme { get; set; }
        public string IcecekTarif { get; set; }
        public string IcecekResim { get; set; }
        public DateTime IcecekTarih
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
        public bool IcecekCesit { get; set; }

        public int KategoriID { get; set; }
        public Kategori Kategori{ get; set; }

        public List<Yorum> Yorumlar { get; set; }
    }
}
