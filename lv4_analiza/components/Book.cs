using System;
using System.Collections.Generic;
using System.Text;

namespace lv4_analiza.components
{
    //zad.3
    class Book : IRentable
    {
        private readonly double BaseVideoPrice = 3.99;
        public String Name { get; private set; }
        public Book(String name) { this.Name = name; }
        public string Description { get { return this.Name; } }
        public double CalculatePrice() { return BaseVideoPrice; }
    }
}