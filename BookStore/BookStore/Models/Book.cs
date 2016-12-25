using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Author { get; set; }
        public int Price { get; set; }
    }
}