using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 

namespace BookStore.Models
{
    public class Purchase
    {
        // Shopping Id
        public int PurchaseId { get; set; }
        // The name and surname of the customer
        public string Person { get; set; }
        // Address of the buyer
        public string Adress { get; set; }
        // ID book
        public int BookId { get; set; }
        // The date of purchase
        public DateTime Date { get; set; }
    }
}