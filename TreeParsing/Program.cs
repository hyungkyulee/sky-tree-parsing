using System;
using System.Linq;
using TreeParsing.Models.Domains;

namespace TreeParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TreeParsing Application");

            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                return;

            try
            {
                var inputNumbers = input.Split(",").Select(int.Parse);
                var tree = new Tree(inputNumbers);
                var postOrderedNumbers = tree.Traverse();

                var output = string.Join(",", postOrderedNumbers.Select(n => n.ToString()));
                Console.WriteLine(output);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{e} : \n>> please check your input is {input}");
            }
        }
    }
}
