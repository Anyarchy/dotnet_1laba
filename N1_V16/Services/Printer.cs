using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_V16.Services
{
    /// <summary>
    /// class to print data
    /// </summary>
    internal static class Printer
    {
        /// <summary>
        /// method to print list of data
        /// </summary>
        /// <typeparam name="T">type of object to print</typeparam>
        /// <param name="collection">collection to print</param>
        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
