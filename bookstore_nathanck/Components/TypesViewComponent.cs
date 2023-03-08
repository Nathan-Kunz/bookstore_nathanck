using bookstore_nathanck.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore_nathanck.Components
{
    public class TypesViewComponent : ViewComponent
    {
        private iBookStoreRepository repo { get; set; }
        public TypesViewComponent(iBookStoreRepository temp)
        {
            repo = temp;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCat = RouteData?.Values["catType"];
            var types = repo.Books.Select(x => x.Category).Distinct()
                .OrderBy(x => x);
            return View(types);
        }
    }
}
