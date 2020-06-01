using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionsIndexer
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Indexer
            //Book book1 = new Book { Id = 1, Name = "Xemse", Author = "Nizami Gencevi" };
            //Book book2 = new Book { Id = 2, Name = "Liyli ve Mecnun", Author = "Mehemmed Fizuli" };
            //Library library = new Library();
            //library.AddBook(book1);
            //library.AddBook(book2);
            //int[] num = { 1, 2, 3, 4 };
            //num[0] = 10;
            //Console.WriteLine(num[2]);
            //library[0] = book1;
            //library[1] = book2;
            //library[99] = new Book { Id = 3, Name = "Sefiller", Author = "Viktor Huqo" };

            //Book[] mybooks = library.books;
            //mybooks[0] = new Book { Id = 100, Name = "Test", Author = "Test" };
            //Console.WriteLine(library.books[0]);
            //Console.WriteLine(library[1000]);
            //Library library1 = new Library("Libraf");
            //library.GetBookList();
            #endregion

            #region Nullable
            //int a;
            //string[] arr = new string[3];
            //int? x = null;
            //bool? isTrue;
            //Sum(20);
            #endregion

            #region Tuple - reference type,ValueTuple - value
            //Tuple
            //Tuple<int, string, string> person = new Tuple<int, string, string>(1,"Kamran","Jabiyev");
            //Console.WriteLine(person.Item1);
            //var number = Tuple.Create(1,"Two",3,4,5,6,true,8);
            //Console.WriteLine(number.Item2);
            //Console.WriteLine(number.Rest.Item1);

            //ValueTuple
            //ValueTuple<int, string, string> person = (1, "Kamran", "Jabiyev");
            //(int Id, string Name, string Surname) person = (1, "Kamran", "Jabiyev");
            //person.Id = 10;
            //var person2 = (Id:2,Name:"Ulvi",Surname:"Mecidov");
            //Console.WriteLine(person2.Id);
            #endregion

            #region Extention - static class-da static method olaraq yazilir ve hansi type-e extend olunursa o tip qebul etdiyi parametrin onunde this keyword-u yazilir.
            string mail = "kamran@code.az";
            //Console.WriteLine(mail.IsEmail());
            //Console.WriteLine(mail.HasChar('a'));
            int a = 5;
            Console.WriteLine(a.GetPower(4));
            //mail.Trim();
            //mail.Replace("", "");
            //IsEmail(mail);
            //Console.WriteLine(IsEmail(mail));
            #endregion
        }

        #region Extention
        //public static bool IsEmail(string str)
        //{
        //    try
        //    {
        //        MailAddress email = new MailAddress(str);
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
            
        //}
        #endregion

        #region Nullable
        //public static void Sum(int x,int? y=null)
        //{
        //    Console.WriteLine(x+y);
        //}
        #endregion
    }
}
