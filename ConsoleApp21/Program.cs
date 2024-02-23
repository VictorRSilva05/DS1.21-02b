using ConsoleApp21.Entities;
namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Victor Rafael da Silva

            List<Decimal> list = new List<Decimal>();

            for (int i = 0; i < 3; i++)
            {
                decimal result = default(decimal);

                Console.Write($"Insert value number {i + 1}: ");
                string input = Console.ReadLine();

                while (!decimal.TryParse(input, out result) || result == Math.Floor(result))
                {
                    Console.Write("Invalid input, try again: ");
                    input = Console.ReadLine();
                }
                list.Add(result);
            }

            Decimals decimals = new Decimals(list);

            Console.WriteLine("\nThe average value: " + decimals.AverageValue(list).ToString("F2"));

            Console.WriteLine();
            decimals.EvenOrOdd(list);

            Console.WriteLine();
            decimals.CorrespondingChar(list);
        }
    }
}
