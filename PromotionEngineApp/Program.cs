//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Self Learing">
//    There is no copyright but this code will not use for any professional purpose it’s just for learning and code practice.
// </copyright>
//-----------------------------------------------------------------------
namespace PromotionEngineApp
{
    using System;
    using System.Collections.Generic;

    /// <summary> Program is the main class from where code will execute</summary>
       public class Program
    {
        /// <summary>Defines the entry point of the application.</summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
            List<ProductsList> products = new List<ProductsList>();
            CalculatePrice calculatePrice = new CalculatePrice();

            Console.WriteLine("total number of order");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("enter the type of product:A,B,C or D");
                string type = Console.ReadLine();
                ProductsList productsList  = new ProductsList(type);
                products.Add(productsList);
            }

            int totalPrice = calculatePrice.GetTotalPrice(products);
            Console.WriteLine(totalPrice);
            Console.ReadLine();
        }
      }
}
