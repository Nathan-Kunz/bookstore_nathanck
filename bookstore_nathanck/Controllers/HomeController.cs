using bookstore_nathanck.Models;
using bookstore_nathanck.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore_nathanck.Controllers
{
    public class HomeController : Controller
    {
        private iBookStoreRepository repo;
        public HomeController(iBookStoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum =1)
        {
            int pageSize = 10;
            var x = new BooksViewModel
            {
                Books = repo.Books
                //.OrderBy(b => b.Price)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPAge = pageNum
                }
            };
            
            return View(x);
        }
   
    }
}
