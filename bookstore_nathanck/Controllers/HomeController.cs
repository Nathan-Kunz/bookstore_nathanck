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

        public IActionResult Index(string catType,int pageNum =1)
        {
            int pageSize = 10;
            var x = new BooksViewModel
            {
                Books = repo.Books
                //.OrderBy(b => b.Price)
                .Where(b=>b.Category == catType|| catType ==null)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = (catType ==null 
                    ? repo.Books.Count()
                    : repo.Books.Where(x =>x.Category ==catType).Count()),
                    BooksPerPage = pageSize,
                    CurrentPAge = pageNum
                }
            };
            
            return View(x);
        }
   
    }
}
