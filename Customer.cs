using System;

namespace SelfService
{
    public class Customer
    {
        private static int jumlahDibeli;
        public static double jumlahDibayar;
        public static int[] Buy(Shirt[] shirts, Pants[] pants)
        {
            Console.WriteLine("\nHow many item do you want to buy?");
            jumlahDibeli = int.Parse(Console.ReadLine());
    
            Console.WriteLine("\nInsert the number from the product list to buy: ");
            try
            {
                int[] dibeli = new int[jumlahDibeli];
                for (int i = 0; i < jumlahDibeli; i++)
                {
                    dibeli[i] = int.Parse(Console.ReadLine()); 
                }

            for (int j = 0;  j < dibeli.Length; j++)
            {
                if(dibeli[j]-1 < shirts.Length)
                {
                    shirts[dibeli[j]-1].Select();
                    Customer.jumlahDibayar += shirts[dibeli[j]-1].price;
                }
                else{
                    pants[dibeli[j]-shirts.Length-1].Select();
                    Customer.jumlahDibayar += pants[dibeli[j]-shirts.Length-1].price;
                }
            }
            return dibeli;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

    }
}