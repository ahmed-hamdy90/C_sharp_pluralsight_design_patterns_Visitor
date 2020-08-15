using System;

namespace VisitorPattern
{
    /// <summary>
    /// item model class
    /// </summary>
    public class Item
    {
        /// <summary>
        /// item id value
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// item price value
        /// </summary>
        public double Price { get; private set; }

        /// <summary>
        /// Item constructor
        /// </summary>
        /// <param name="id">id value for item</param>
        /// <param name="price">price value for item</param>
        public Item(int id, double price)
        {
            Id = id;
            Price = price;
        }

        /// <summary>
        /// Retrieve the discount value for item according to price and given discount percentage
        /// </summary>
        /// <param name="discount">discount percentage value</param>
        /// <returns>calculated discount for item</returns>
        public double GetDiscount(double discount)
        {
            double calculatedDiscount = Price * discount;
            return Math.Round(calculatedDiscount, 2);
        }
    }
}