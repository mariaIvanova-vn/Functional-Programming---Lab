﻿using System;
using System.Linq;

namespace _04._Add_VAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<decimal, decimal> addVAT = x => x * 1.20m;

            string input = Console.ReadLine();
            string[] token=input.Split(", ");
            decimal[] nums=token.Select(decimal.Parse).ToArray();
            decimal[] numsWithVat=nums.Select(addVAT).ToArray();

            Array.ForEach(numsWithVat, x => Console.WriteLine("{0:f2}", x));
        }
    }
}
