﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Book:Product
    {
        public string Author;
        public string Genre;

        public override void GetInfo()
        {
            Console.WriteLine($"Name: {Name} - Price: {Price} - Author: {Author} - Genre: {Genre}");
        }
    }
}
