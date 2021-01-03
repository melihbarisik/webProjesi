using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webProjeV2.Models
{
    public class Kitap
    {
        
        public int KitapId { get; set; }

        [Display(Name = "KitapIsmi")]
        [MaxLength(100)]
        [Required]
        public string kitapIsmi { get; set; }

        [Display(Name = "KitapFiyat")]
        [Required]
        public double kitapFiyat { get; set; }

        [Display(Name = "KitapResimUrl")]
        [MaxLength(250)]
        [Required]
        public string kitapResimUrl { get; set; }

        [Display(Name = "KitapSayfaSayisi")]
        [Required]
        public int kitapSayfaSayisi { get; set; }

        [Display(Name = "KitapAciklama")]
        [Required]
        public string kitapAciklama { get; set; }

        [Display(Name = "KitapKategori")]
        [Required]
        public string kitapKategori { get; set; }

    }
}
