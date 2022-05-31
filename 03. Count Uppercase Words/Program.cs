using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main() => Console.WriteLine(string.Join("\r\n", Console.ReadLine()
            .Split()
            .Where(x=>x.Length>0 && char.IsUpper(x[0]))));
        
    }
}
