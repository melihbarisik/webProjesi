using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Linq;
using System.Threading.Tasks;


namespace webProjeCalismasi.Models
{
    public class Kitaplar
    {

    
        public int KitaplarId { get; set; }

        [MaxLength(100)]
        [Required]

        public string kitapIsmi { get; set; }
    }
}