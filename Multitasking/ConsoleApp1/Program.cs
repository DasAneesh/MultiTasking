using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListofNumbers ints = new ListofNumbers();
            ints.AddNumbers(20000);
            Console.WriteLine(ints.CalculateParallelsum(5));
            Console.ReadLine();
        }
    }
}
