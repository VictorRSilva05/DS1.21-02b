using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Entities
{
    internal class Decimals
    {
        //Victor Rafael da Silva
        public List<decimal> decimals {  get; set; }

        public Decimals(List<decimal> decimals)
        {
            this.decimals = decimals;
        }

        public decimal AverageValue(List<decimal> decimals)
        {
            return decimals.Average();
        }

        public void EvenOrOdd(List<decimal> decimals)
        {
            int integer;
            foreach (decimal c in decimals)
            {
                integer = (int)c;
                if (integer % 2 == 0)
                {
                    Console.WriteLine($"{integer} is even");
                }
                else
                {
                    Console.WriteLine($"{integer} is odd");
                }
            }
        }

        public void CorrespondingChar(List<decimal> decimals)
        {
            foreach (decimal c in decimals)
            {
                string[] strings = c.ToString().Split(",");
                int numbers = int.Parse(strings[1]);
                char chars = Convert.ToChar(numbers);
                Console.WriteLine(chars);
            }
        }
    }
}
