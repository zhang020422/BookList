using System;

namespace BookList.Models
{
    public class Book
    {
        public int id { get; set; }
        public string isbn { get; set; }
        public string bookName { get; set; }
        public string author { get; set; }
        public string press { get; set; }
        public DateTime pressDate { get; set; }
        public double price { get; set; }
        public string barcode { get; set; }
        public string size { get; set; }
        public double weight { get; set; }
        public int format { get; set; }
    }
}