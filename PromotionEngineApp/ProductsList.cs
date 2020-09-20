//-----------------------------------------------------------------------
// <copyright file="ProductsList.cs" company="Self Learing">
//   There is no copyright but this code will not use for any professional purpose it’s just for learning and code practice.
// </copyright>
//-----------------------------------------------------------------------
namespace PromotionEngineApp
{
    /// <summary>Product List class</summary>
    public class ProductsList
    {
        /// <summary>Gets or sets the Product Code.</summary>
        /// <value>The Product Code.</value>
        public string ProductCode { get; set; }

        /// <summary>Gets or sets the Product Price.</summary>
        /// <value>The Product Price.</value>
        public decimal ProductPrice { get; set; }

        /// <summary>Initializes a new instance of the product list <a onclick="return false;" href="ProductsList" originaltag="see">ProductsList</a> class.</summary>
        /// <param name="productCode">The identifier.</param>
        public ProductsList(string productCode)
        {
            this.ProductCode = productCode;
            switch (productCode)
            {
                case "A":
                    this.ProductPrice = 50m;

                    break;
                case "B":
                    this.ProductPrice = 30m;

                    break;
                case "C":
                    this.ProductPrice = 20m;

                    break;
                case "D":
                    this.ProductPrice = 2015m;
                    break;
            }
        }
    }
}
