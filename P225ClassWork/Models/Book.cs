using System;
using System.Collections.Generic;
using System.Text;

namespace P225ClassWork.Models
{
    class Book
    {
        private static int _count;
        public string Code { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }

        public Book(string name, string authorname, int pagecount)
        {
            _count++;
            Code = $"{name[0..2].ToUpper()}{_count}";
            Name = name;
            AuthorName = authorname;
            PageCount = pagecount;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nMuellifi: {AuthorName}\n Sehife Sayi: {PageCount}\n Codu: {Code}";
        }
    }
}
