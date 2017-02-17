using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Enter 'end' when you have finished");

            string newInput = Console.ReadLine();

            while (null != newInput && "END" != newInput.ToUpper())
            {
                newInput = Console.ReadLine();
            }

            Thread.Sleep(System.TimeSpan.FromSeconds(2));
        }
    }
}
