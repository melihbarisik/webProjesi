using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Localization;
using webProjeV2.Models;

namespace webProjeV2.Controllers
{
    [Authorize(Roles = "Admin,Kullanici")]

    public class KitapController : Controller
    {
        private readonly IStringLocalizer<KitapController> _stringLocalizer;

        public KitapController(IStringLocalizer<KitapController> stringLocalizer)
        {
            
            _stringLocalizer = stringLocalizer;

        }

        public static SqlConnection GetSqlConnection()
        {
         
            return new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=aspnet-webProjeV2;Trusted_Connection=True;MultipleActiveResultSets=true");
            
        }
        public static List<Kitap> GetAllBooks()
        {
            List<Kitap> kitaplarListesi = null;

            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string sql = "select * from  Kitaplar";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    kitaplarListesi = new List<Kitap>();

                    while (reader.Read())
                    {
                        kitaplarListesi.Add(

                            new Kitap
                            {
                                KitapId = int.Parse(reader["KitapId"].ToString()),
                                kitapIsmi = (reader["kitapIsmi"].ToString()),
                                kitapFiyat = double.Parse(reader["kitapFiyat"].ToString()),
                                kitapResimUrl = (reader["kitapResimUrl"].ToString()),
                                kitapSayfaSayisi = int.Parse(reader["kitapSayfaSayisi"].ToString()),
                                kitapAciklama = (reader["kitapAciklama"].ToString()),
                                kitapKategori = (reader["kitapKategori"].ToString()),
                            }
                           );
                    }

                    reader.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    connection.Close();
                }

            }

            return kitaplarListesi;
        }
        public IActionResult Index()
        {
            return View(GetAllBooks());
        }

        [HttpPost]
        public IActionResult KitapGorunum(int id)
        {
            var kitap = FindBook.FindById(GetAllBooks(),id);
            return View(kitap);
        }
    }
}
