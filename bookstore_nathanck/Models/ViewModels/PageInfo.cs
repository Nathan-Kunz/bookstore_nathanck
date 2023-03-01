using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore_nathanck.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int CurrentPAge { get; set; }
        //how many pages
        public int TotalPages => (int)Math.Ceiling((double)TotalNumBooks / BooksPerPage);


    }
}
