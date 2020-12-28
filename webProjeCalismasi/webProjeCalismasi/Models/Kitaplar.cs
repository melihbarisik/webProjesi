using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using webProjeCalismasi.Models.Entity;

namespace webProjeCalismasi.Models
{
    public class Kitaplar
    {
        
        public int KitaplarId { get; set; }

        [MaxLength(100)]
        [Required]
        public string kitapIsmi { get; set; }
        public decimal kitapFiyat { get; set; }

        [MaxLength(100)]
        [Required]
        public string kitapResimUrl { get; set; }

        [Required]
        public int kitapSayfaSayisi { get; set; }

        
        public int CategoryId { get; set; }
        
        
        public int KullaniciId { get; set; }

        public Category Ka { get; set; }
        public Kullanici Ku { get; set; }



    }
}
    