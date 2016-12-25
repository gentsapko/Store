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
    }
}