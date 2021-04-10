using System;

namespace SelfService
{
    public class Shirt : Apparel
    {
        private static int totalShirts;
        public Shirt(string type, string brand, string size, double price, int stock)
        {
            this.type = type;
            this.brand = brand;
            this.size = size;
            this.price = price;
            this.stock = stock;
            totalShirts++;
            totalpcs++;
        }
        public void Select()
        {
            this.stock--;
            Console.WriteLine(type + " " + brand + " " + size + " added");
        }
        public static new int Total()
        {
            return totalShirts;
        }

    }
}