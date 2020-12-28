using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using webProjeCalismasi.Models.Entity;

namespace webProjeCalismasi.Models.Entity
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }

        [MaxLength(10)]
        [Required]
        public string kullaniciAdi { get; set; }

        [MaxLength(10)]
        [Required]
        public string kullaniciSoyAdi { get; set; }

        [MaxLength(100)]
        [Required]
        public string kullaniciAdresi { get; set; }

        [MaxLength(10)]
        [Required]
        public string kullaniciTelNo { get; set; }

        [MaxLength(25)]
        [Required]
        public string kullaniciMailAdresi { get; set; }

        public ICollection<Kitaplar> Kitaplar { get; set; }

    }
}
