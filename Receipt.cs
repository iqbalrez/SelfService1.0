using System;

namespace SelfService
{
    public class Receipt
    {
        public static void Print(Shirt[] shirts, Pants[] pants, int[] dibeli)
        {
            Console.WriteLine("\n-------------------- STRUK --------------------");
            for (int i = 0;  i < dibeli.Length; i++)
            {
                if(dibeli[i]-1 < shirts.Length)
                {
                    Console.WriteLine(shirts[dibeli[i]-1].brand + "\t" + shirts[dibeli[i]-1].type + "\t" + shirts[dibeli[i]-1].size + "\t" + shirts[dibeli[i]-1].price);
                }
                else{
                    Console.WriteLine(pants[dibeli[i]-shirts.Length-1].brand + "\t" + pants[dibeli[i]-shirts.Length-1].type + "\t" + pants[dibeli[i]-shirts.Length-1].size + "\t" + pants[dibeli[i]-shirts.Length-1].price);
                }
            }
            System.Console.WriteLine("Total --------------------------------- " + Customer.jumlahDibayar);
        }
    }
}