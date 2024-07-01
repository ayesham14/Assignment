using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wordsame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            if (word1 == word2)
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are the same.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"The words '{word1}' and '{word2}' are not the same.");
                Console.ReadLine();
            }
        }
    }
}
