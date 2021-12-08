using System;
using System.Collections.Generic;
using System.Text;
using UnitTesting;

namespace Tests
{
    public static class DataSource
    {
       public  static    List<Book> books = new List<Book>
        {
                new Book{ Title="Harry Potter and the Sorcerer’s Stone", Price=8, Number=1 },
                new Book{ Title="Harry Potter and the Chamber of Secrets", Price=8, Number=2},
                new Book{ Title="Harry Potter and the Prisoner of Azkaban", Price=8, Number=3},
                new Book{ Title="Harry Potter and the Goblet of Fire", Price=8, Number=4},
                new Book{ Title="Harry Potter and the Order of the Phoenix", Price=8, Number=5},
                new Book{ Title="Harry Potter and the Sorcerer’s Stone", Price=8, Number=1 },
                new Book{ Title="Harry Potter and the Chamber of Secrets", Price=8, Number=2},
                new Book{ Title="Harry Potter and the Prisoner of Azkaban", Price=8, Number=3}

        };
    }
}
