using System;
using System.Collections.Generic;
using System.Text;

namespace P225ClassWork.Models
{
    class Library
    {
        public List<Book> Books;

        public Library()
        {
            Books = new List<Book>();
        }

        public List<Book> FindAllBooksByName(string name)
        {
            return Books.FindAll(book => book.Name.Contains(name));
            //return Books.FindAll(delegate (Book book) { return book.Name.Contains(name); });
        }

        public void RemoveAllBookByName(string name)
        {
            Books.RemoveAll(b => b.Name.Contains(name));
        }

        public List<Book> SearchBooks(string search)
        {
            return Books.FindAll(b => b.Name.ToLower().Contains(search.Trim().ToLower()) ||
            b.AuthorName.ToLower().Contains(search.Trim().ToLower()) ||
            b.PageCount.ToString().Contains(search.Trim().ToLower()));
        }

        public List<Book> FindAllBooksByPageCountRange(int min, int max)
        {
            //if (min > max)
            //{
            //Intervyu Suali
            //    min = min + max;
            //    max = min - max;
            //    min = min - max;
            //}

            return Books.FindAll(b => b.PageCount >= min && b.PageCount <= max);
        }

        public void RemoveByNo(string no)
        {
            Book book = Books.Find(b => b.Code == no);

            if (book != null)
            {
                Books.Remove(book);
            }
            else
            {
                Console.WriteLine("Tapilmadi");
            }

        }

        //public bool FindAllBook(Book book)
        //{
        //    return book.Name.Contains("Nizam");
        //}
    }
}
