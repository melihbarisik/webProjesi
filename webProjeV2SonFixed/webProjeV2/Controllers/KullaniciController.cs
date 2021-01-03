using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Localization;
using webProjeV2.Models;

namespace webProjeV2.Controllers
{
    public class KullaniciController : Controller
    {
        private readonly IStringLocalizer<KullaniciController> _stringLocalizer;

        public KullaniciController(IStringLocalizer<KullaniciController> stringLocalizer)
        {

            _stringLocalizer = stringLocalizer;

        }

        public static SqlConnection GetSqlConnection()
        {

            return new SqlConnection("Server=(localdb)\\mssqllocaldb;Database=aspnet-webProjeV2;Trusted_Connection=True;MultipleActiveResultSets=true");

        }
        public static List<Kullanici> GetAllUsers()
        {
            List<Kullanici> userListesi = null;

            using (var connection = GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string sql = "select * from  AspNetUsers";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    userListesi = new List<Kullanici>();

                    while (reader.Read())
                    {
                        userListesi.Add(

                            new Kullanici
                            {
                                Id = reader["Id"].ToString(),
                                UserName = (reader["UserName"].ToString()),
                                KullaniciAdVeSoyad = (reader["KullaniciAdVeSoyad"].ToString()),
                                KullaniciCinsiyet = reader["KullaniciCinsiyet"].ToString(),
                                DogumTarihi = DateTime.Parse(reader["DogumTarihi"].ToString()),
                                Email = reader["Email"].ToString(),

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

            return userListesi;
        }
        public IActionResult Index()
        {
            return View(GetAllUsers());
        }


    }
}
