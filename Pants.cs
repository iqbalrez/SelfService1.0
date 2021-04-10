using System;

namespace SelfService
{
    public class Pants : Apparel
    {
        private static int totalPants;
        public Pants(string type, string brand, string size, double price, int stock)
        {
            this.type = type;
            this.brand = brand;
            this.size = size;
            this.price = price;
            this.stock = stock;
            totalPants++;
            totalpcs++;
        }   
        public void Select()
        {
            this.stock--;
            Console.WriteLine(type + " " + brand + " " + size + " added");
        }
        public static new int Total()
        {
            return totalPants;
        }
    }
}