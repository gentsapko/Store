using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Views.Home
{
    public class HomeController : Controller
    {
        //create data contex
        BookContext db = new BookContext();

        
        public ActionResult Index()
        {
            //get without db all object Book
            IEnumerable<Book> books = db.Books;
            //We pass all the objects in the dynamic property of Books in ViewBag
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

            // Add the purchase information in the database
            db.Purchases.Add(purchase);

            // Stored in the database changes
            db.SaveChanges();
            return purchase.Person + ", thank you for your purchase";
        }
        
    }
}