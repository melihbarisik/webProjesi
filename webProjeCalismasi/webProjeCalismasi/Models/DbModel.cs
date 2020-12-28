using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjeCalismasi.Models.Entity;

namespace webProjeCalismasi.Models
{
    public class DbModel
    {
        public Kitaplar Kitap { get; set; }
        public Category Kategori { get; set; }
        public Kullanici Kullanici { get; set; }


    }
}
