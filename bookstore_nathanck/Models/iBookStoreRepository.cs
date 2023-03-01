using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore_nathanck.Models
{
    public interface iBookStoreRepository
    {
        IQueryable<Book> Books { get; }

    }
}
