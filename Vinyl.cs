namespace VisitorPattern
{
    /// <summary>
    /// Vinyl model class
    /// </summary>
    public class Vinyl : Item
    {
        /// <summary>
        /// Vinyl Constructor
        /// </summary>
        /// <param name="id">id value for vinyl</param>
        /// <param name="price">price value for vinyl</param>
        public Vinyl(int id, double price) : base(id, price)
        {
        }
    }
}