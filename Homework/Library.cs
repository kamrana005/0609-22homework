using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Library
    {
        public Library()
        {
            Products = new Product[0];
        }

       public  Product[] Products;

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length-1] = product;
        }

        public int GetJournalsCount()
        {
            int count = 0;
            foreach(var item in Products)
            {
                if(item is Journal)
                    count++;
            }
            return count;
        }

        public int GetBooksCount()
        {
            int count = 0;
            foreach(var item in Products)
            {
                if (item is Book)
                    count++;
                   
            }
            return count;
        }

       
    }
}
