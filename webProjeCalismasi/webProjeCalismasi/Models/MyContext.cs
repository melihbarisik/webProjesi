using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webProjeCalismasi.Models.Entity;

namespace webProjeCalismasi.Models
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> options)
         : base(options)
        { }

        public DbSet<Kitaplar> Kitaplar { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Category> Kategoriler { get; set; }

       
    }
}
    