using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore_nathanck.Models
{
    public class EFBookProjectRepository : iBookStoreRepository
    {
        private BookstoreContext context { get; set; }
        public EFBookProjectRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
