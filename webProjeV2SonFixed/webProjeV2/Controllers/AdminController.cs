using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using webProjeV2.Models;

namespace webProjeV2.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {

        private readonly ILogger<AdminController> _logger;

        private readonly IStringLocalizer<AdminController> _stringLocalizer;


        public AdminController(ILogger<AdminController> logger, IStringLocalizer<AdminController> stringLocalizer)
        {
            _logger = logger;
            _stringLocalizer = stringLocalizer;

        }

        public IActionResult Index()
        {
            return View(KitapController.GetAllBooks());
        }
        public IActionResult IndexUsers()
        {
            return View(KullaniciController.GetAllUsers());
        }

        public IActionResult AdminPage()
        {
            return View(KitapController.GetAllBooks());
        }

        public IActionResult AdminSil(int id)
        {
            using (var connection = KitapController.GetSqlConnection())
            {
                Kullanici yedekKullanici = new Kullanici();
                connection.Open();
                string sql = "delete from Kitaplar  where KitapId = '" + id + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

            }

            return RedirectToAction("Index");
        }
        public IActionResult AdminSilUser(string id)
        {
            using (var connection = KullaniciController.GetSqlConnection())
            {
                Kullanici yedekKullanici = new Kullanici();
                connection.Open();
                string sql = "delete from AspNetUsers  where Id = '" + id + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

            }

            return RedirectToAction("IndexUsers");
        }

        public IActionResult AdminEkle()
        {
            return View();
        }

        public IActionResult AdminKitapEkleVeritabani(Kitap kitap)
        {
            using (var connection = KitapController.GetSqlConnection())
            {
                Kullanici yedekKullanici = new Kullanici();
                connection.Open();
                string sql = "insert into Kitaplar(kitapIsmi,kitapFiyat,kitapResimUrl,kitapSayfaSayisi,kitapAciklama,kitapKategori) values('" + kitap.kitapIsmi + "','" + kitap.kitapFiyat + "','" + kitap.kitapResimUrl + "','" + kitap.kitapSayfaSayisi + "','" + kitap.kitapAciklama + "','" + kitap.kitapKategori + "')";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            return RedirectToAction("Index");
        }

        public IActionResult AdminIncele(int id)
        {
            var item = FindBook.FindById(KitapController.GetAllBooks(), id);
            return View(item);
        }

        public IActionResult AdminGuncelle(int id)
        {
            var item = FindBook.FindById(KitapController.GetAllBooks(), id);
            return View(item);
        }
        public IActionResult AdminGuncelleUser(string id)
        {
            var item = FindUser.FindById(KullaniciController.GetAllUsers(), id);
            return View(item);
        }

        public IActionResult AdminKullaniciGüncelleVeritabani(Kullanici user)
        {

            using (var connection = KullaniciController.GetSqlConnection())
            {

                connection.Open();
                string sql = "Update AspNetUsers set UserName='" + user.UserName + "',KullaniciAdVeSoyad='" + user.KullaniciAdVeSoyad + "',KullaniciCinsiyet ='" + user.KullaniciCinsiyet + "',DogumTarihi = '" + user.DogumTarihi + "',Email='" + user.Email + "' Where Id ='" + user.Id + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            return RedirectToAction("IndexUsers");
        }
        public IActionResult AdminKitapGüncelleVeritabani(Kitap kitap)
        {

            using (var connection = KitapController.GetSqlConnection())
            {

                

                Kullanici yedekKullanici = new Kullanici();
                connection.Open();
                string sql = "Update Kitaplar set kitapIsmi='" + kitap.kitapIsmi + "',kitapFiyat='" + kitap.kitapFiyat + "',kitapResimUrl ='" + kitap.kitapResimUrl + "',kitapSayfaSayisi = '" + kitap.kitapSayfaSayisi + "',kitapAciklama='" + kitap.kitapAciklama + "',kitapKategori = '" + kitap.kitapKategori + "' Where KitapId ='" + kitap.KitapId + "'";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

            }
            return RedirectToAction("Index");
        }
    }
}
