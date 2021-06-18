using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11
{
    class Program
    {
        static void Main()
        {
            int[] array = { 0, 1, 2, 30, 4, 5, 6, 0, 7, 8, 0, 9, 10 };
            Console.WriteLine($"Количество нулей - {array.Count(e => e == 0)}");
        }
    }
    
}