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
            int n;
            Console.WriteLine("enter integrer number");
            while (!int.TryParse(Console.ReadLine(), out n)){
                Console.WriteLine("number is invalid");
                Console.WriteLine("Enter valid integer number");
            }

            for (int i = 0; i <= n; i += 2 )
            {
                if (i == 0)
                {
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
