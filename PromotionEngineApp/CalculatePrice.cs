//-----------------------------------------------------------------------
// <copyright file="CalculatePrice.cs" company="Self Learing">
//   There is no copyright but this code will not use for any professional purpose it’s just for learning and code practice.
// </copyright>
//-----------------------------------------------------------------------
namespace PromotionEngineApp
{
    using System;
    using System.Collections.Generic;
    using PromotionEngineApp.Interface;

    /// <summary> CalculatePrice class is calculate Price for the items </summary>
    public class CalculatePrice : ICalculatePrice
    {
        /// <summary>Gets the total price.</summary>
        /// <param name="products">The products.</param>
        /// <returns>The Price of product </returns>
        public int GetTotalPrice(List<ProductsList> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int counterofC = 0;
            int priceofC = 20;
            int counterofD = 0;
            int priceofD = 15;
            try
            {
                foreach (ProductsList productsList in products)
                {
                    if (productsList.ProductCode == "A" || productsList.ProductCode == "a")
                    {
                        counterofA = counterofA + 1;
                    }

                    if (productsList.ProductCode == "B" || productsList.ProductCode == "b")
                    {
                        counterofB = counterofB + 1;
                    }

                    if (productsList.ProductCode == "C" || productsList.ProductCode == "c")
                    {
                        counterofC = counterofC + 1;
                    }

                    if (productsList.ProductCode == "D" || productsList.ProductCode == "d")
                    {
                        counterofD = counterofD + 1;
                    }
                }

                int totalProductPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
                int totalProductPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
                int totalProductPriceofC = counterofC * priceofC;
                int totalProductPriceofD = counterofD * priceofD;
                return totalProductPriceofA + totalProductPriceofB + totalProductPriceofC + totalProductPriceofD;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Console.WriteLine("Total Price Display Below :");
            }
        }
    }
}
