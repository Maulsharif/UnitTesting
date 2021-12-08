using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace UnitTesting
{

    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public decimal Number { get; set; }
        public int CompareTo([AllowNull] Book otherBook)
        {
            if (otherBook == null) throw new ArgumentNullException(nameof(otherBook));
            if (this.Number == otherBook.Number)
                return 0;
            else if (this.Number > otherBook.Number)
                return 1;
            else return -1;
        }
    }

    static public class DiscountCounter
    {
        static int counter = 0;
        static decimal discount = 0;
        static decimal k = 0;
       
        static decimal GetDiscountRate(int number)
        {
          
            if (number == 5) k = 0.25M;
            if (number == 4) k = 0.20M;
            if (number == 3) k = 0.1M;
            if (number == 2) k = 0.05M;
            return k;
        }


        public static decimal CountDiscountSum(List<Book> books, int number)
        {
            List<Book> newBooks = new List<Book>();
            k = GetDiscountRate(number);
            books.Sort();

            for (int i = 0; i < books.Count - 1; i++)
            {
                if (books[i].Number < books[i + 1].Number)
                {
                    counter++;
                }
                else
                {
                    newBooks.Add(books[i]);
                }
            }

            discount += 8 - ((counter + 1) / number) * k * 8;

            if (newBooks.Count >= 5)
            {
                CountDiscountSum(newBooks, 5);
            }
            else if (newBooks.Count >= 4)
            {
                CountDiscountSum(newBooks, 4);
            }
            else if (newBooks.Count >= 3)
            {
                CountDiscountSum(newBooks, 3);
            }
            else if (newBooks.Count >= 2)
            {
                CountDiscountSum(newBooks, 2);
            }
            else
            {
                return discount;
            }
            return discount;
        }
    }



    
}
