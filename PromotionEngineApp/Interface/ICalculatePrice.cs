//-----------------------------------------------------------------------
// <copyright file="ICalculatePrice.cs" company="Self Learing">
//   There is no copyright but this code will not use for any professional purpose it’s just for learning and code practice.
// </copyright>
//-----------------------------------------------------------------------
namespace PromotionEngineApp.Interface
{
    using System.Collections.Generic;

    /// <summary> Interface Calculate price </summary>
  public interface ICalculatePrice
    {
        /// <summary>Gets the total price.</summary>
        /// <param name="products">The products.</param>
        /// <returns> Total price</returns>
        int GetTotalPrice(List<ProductsList> products);
    }
}
