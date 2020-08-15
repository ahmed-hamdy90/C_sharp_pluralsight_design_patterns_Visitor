namespace VisitorPattern
{
    /// <summary>
    /// Book model class
    /// </summary>
    public class Book : Item
    {
        /// <summary>
        /// Book Constructor
        /// </summary>
        /// <param name="id">id value for book</param>
        /// <param name="price">price value for book</param>
        public Book(int id, double price) : base(id, price)
        {
        }
    }
}