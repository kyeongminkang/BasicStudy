using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPropertyEx
{
    // 추상클래스에서의 프로퍼티
    abstract class Book
    {
        private static int isbn = 0;
        public string ISBN
        {
            get
            {
                return string.Format("{0:d4}", isbn++);
            }
        }

        // 추상 프로퍼티 : 구현이 안된 프로퍼티 abstract가 붙어있기 때문에!
        abstract public DateTime BookDate
        {
            get; set;
        }
    }

    class MyBook : Book
    {
        public override DateTime BookDate
        { get; set; }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new MyBook()
            {
                BookDate = new DateTime(2015, 10, 10)
            };

            Book book2 = new MyBook()
            {
                BookDate = new DateTime(2017, 7, 7)
            };

            Console.WriteLine($"Book : {book1.ISBN}, Book Date : {book1.BookDate}");
            Console.WriteLine($"Book : {book2.ISBN}, Book Date : {book2.BookDate}");

        }
    }
}
