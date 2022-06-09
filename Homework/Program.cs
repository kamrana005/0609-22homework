using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            Book book1 = new Book()
            {
                Author = "AAA",
                Genre = "Dram",
                Name = "CCC",
                Price = 15
            };
            Book book2 = new Book()
            {
                Author = "QQQ",
                Genre = "Dram",
                Name = "TTT",
                Price = 12
            };
            Book book3 = new Book()
            {
                Author = "RRR",
                Genre = "Horror",
                Name = "UUU",
                Price = 19
            };
            Journal journal = new Journal()
            {
                Company = "American",
                Name = "TTT",
                Price = 23
            };
            Journal journal1 = new Journal()
            {
                Company = "Japan",
                Name = "YYY",
                Price = 29
            };
            Journal journal2 = new Journal()
            {
                Company = "Britain",
                Name = "PPP",
                Price = 45

            };

            library.AddProduct(book1);
            library.AddProduct(book2);
            library.AddProduct(book3);
            library.AddProduct(journal);
            library.AddProduct(journal1);
            library.AddProduct(journal2);

            Console.WriteLine(library.GetBooksCount());

            Product[] products = new Product[]
            {
                book1,
                book2,
                book3,
                journal,
                journal1,
                journal2
            };


            foreach (var item in products)
            {
                item.GetInfo();
            }

            switch()
            {
                case 1:
                    {

                    }

            
            
         
            
        }
    }
}
