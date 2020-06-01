using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsIndexer
{
    class Library
    {
        public int Id { get; set; }
        public string Name { get; set; }
        private readonly Book[] books;

        public Library()
        {
            books = new Book[100];
        }
        public Library(string name)
        {
            Name = name;
        }

        public Book this[int i]
        {
            get
            {
                try
                {
                    return books[i];
                }
                catch (Exception)
                {

                    return books[0];
                }
                 
            }
            set
            {
                books[i] = value;
            }
        }

        //public void AddBook(Book book)
        //{
        //    Array.Resize(ref books, books.Length + 1);
        //    books[books.Length - 1] = book;
        //}

        public void GetBookList()
        {
            foreach (Book item in books)
            {
                if(item!=null)
                    Console.WriteLine(item);
            }
        }
    }
}
