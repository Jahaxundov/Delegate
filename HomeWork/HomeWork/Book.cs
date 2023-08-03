using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author{ get; set; }

        public bool CheckBookAuthor(Book book)
        {
            return book.Author == "Nizami";
        }

        public void ExecuteMethod()
        {
            List<Book> list = new()
            {
               new Book{Name="Leyli ve Mecnun",Author="Nizami"},
               new Book{Name="Voyna i mir",Author="Lev Tolsoy"},
               new Book{Name="Isgendername",Author="Nizami"}


            };
            CheckAuthor(list, CheckBookAuthor);
        }

        private void CheckAuthor(List<Book> books, Predicate<Book> func)
        {
            int count = 0;

            foreach (var item in books)
            {
                if (func(item))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
