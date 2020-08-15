using System;
using System.Collections.Generic;

namespace VisitorPattern
{
    /// <summary>
    /// The main Program class
    /// </summary>
    class Program
    {
        /// <summary>
        /// The main static method for program
        /// </summary>
        /// <param name="args">given arguments list for program</param>
        static void Main(string[] args)
        {
            List<Object> items = new List<object>()
            {
                new Book(12345, 11.99),
                new Book(78910, 22.79),
                new Vinyl(11198, 17.99),
                new Book(63254, 9.79)
            };
        }
    }
}
