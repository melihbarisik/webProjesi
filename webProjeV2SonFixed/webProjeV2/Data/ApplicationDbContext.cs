using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using webProjeV2.Models;

namespace webProjeV2.Data
{
    public class ApplicationDbContext : IdentityDbContext<Kullanici>
    {
        public DbSet<Kitap> Kitaplar { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {}



     

        
    }
}
