using System;
using System.Linq;

namespace _02._Sum_Numbers
{
    internal class Program
    {
        static int Parse(string str)
        {
            int result = int.Parse(str);
            return result;  
        }
        static void Main(string[] args)
        {
           string input=Console.ReadLine();
            int[] nums = input.Split(", ").Select(Parse).ToArray();
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Sum()); 
        }
    }
}
