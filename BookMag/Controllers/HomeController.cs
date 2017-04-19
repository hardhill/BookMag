using BookMag.Models;
using BookMag.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookMag.Controllers
{
    public class HomeController : Controller
    {
        //создаем контекст данных
        BookConext db = new BookConext();

        // GET: Home
        public ActionResult Index()
        {
            // получаем из бд все объекты Book
            IEnumerable<Book> books = db.Books;
            // передаем данные в ViewBag
            ViewBag.Books = books;

            return View();
        }

        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }

        public ActionResult GetIP()
        {

            return new HtmlResult("<h2>"+HtmlResult.GetIp(Request.RequestContext)+"</h2>");
        }

        public ActionResult GetImage()
        {
            string path = "../Content/Images.jpg";
            return new ImageResult(path);
        }
    }
}