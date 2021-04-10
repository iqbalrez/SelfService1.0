using System;

namespace SelfService
{
    class Program
    {
        static void Main(string[] args)
        {
            Shirt[] shirts = new Shirt[3];
            shirts[0] = new Shirt("Long Sleeve", "ZARA    ", "S ", 149000, 50);
            shirts[1] = new Shirt("Hoodie     ", "H&M     ", "S ", 119000, 50);
            shirts[2] = new Shirt("Jacket     ", "Uniqlo  ", "M ", 299000, 30);

            Pants[] pants = new Pants[3];
            pants[0] = new Pants("Chinos     ", "Erigo   ", "32", 100000, 50);
            pants[1] = new Pants("Short      ", "Levi's  ", "33", 110000, 50);
            pants[2] = new Pants("Jeans      ", "Uniqlo  ", "34", 129000, 30);

            Console.WriteLine("-------------= Self Service =-------------");
            Console.WriteLine("There are " + Apparel.Total() + " pcs of Apparel on hand");
            Console.WriteLine("(" + Shirt.Total() + " pcs of Shirts and " + Pants.Total() + " pcs of Pants)");
            Console.WriteLine("\nProduct List:");
            for (int i = 0; i < shirts.Length; i++)
            {
                Console.WriteLine(i+1 + ". " + shirts[i].Show());
            }
            for (int i = 0; i < pants.Length; i++)
            {
                Console.WriteLine(i+shirts.Length+1 + ". " + pants[i].Show());
            }
            
            int[] dibeli = Customer.Buy(shirts, pants);
            Receipt.Print(shirts, pants, dibeli);
        }
    }
}