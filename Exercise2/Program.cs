using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    /// <summary>
    /// Exercise 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Uses ordered generic dynamic array
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            Prostokat prostokat1 = new Prostokat(3, 4);
            Prostokat prostokat2 = new Prostokat(2, 5);

            OrderedDynamicArray<Prostokat> tablica = new OrderedDynamicArray<Prostokat>();

            Console.WriteLine();
        }
    }
}
