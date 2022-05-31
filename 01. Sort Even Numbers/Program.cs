using System;
using System.Linq;

namespace _01._Sort_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parse=x=>int.Parse(x);
            Func<int, bool> isEven = x => x % 2 == 0;

            string input=Console.ReadLine();
            string[] token = input.Split(", ");
            int[] nums=token.Select(parse).ToArray();
            int[] evenNums=nums.Where(isEven).ToArray();
            int[] orderEvenNums=evenNums.OrderBy(n=>n).ToArray();

            Console.WriteLine(string.Join(", ", orderEvenNums));
        }
    }
}
