using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webProjeV2.Models
{
    public class Kullanici:IdentityUser
    {
        [Display(Name="Adı & Soyadı")]
        public string KullaniciAdVeSoyad { get; set; }

        [Display(Name = "Cinsiyet")]
        public string KullaniciCinsiyet{ get; set; }

        [Display(Name ="Doğum Tarihi")]
        [DataType(DataType.DateTime)]
        public DateTime DogumTarihi{ get; set; }
    }
}
