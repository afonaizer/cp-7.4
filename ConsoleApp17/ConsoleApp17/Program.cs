using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            StringBuilder s = new StringBuilder(Console.ReadLine());
            StringBuilder s1 = s.Replace("х", string.Empty);
            Console.Write($"Строка без х: {s1}");
            Console.ReadKey();

        }
    }
}
