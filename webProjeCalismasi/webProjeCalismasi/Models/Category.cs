using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using webProjeCalismasi.Models.Entity;

namespace webProjeCalismasi.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [MaxLength(100)]
        [Required]
        public string CategoryIsmi { get; set; }

        public ICollection<Kitaplar> Kitaplar { get; set; }
    }
}
