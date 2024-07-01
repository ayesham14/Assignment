using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringreverseaword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
  
            string reversedWord = ReverseString(word); // Reverse the word

            Console.WriteLine($"The reverse of '{word}' is: {reversedWord}");
            Console.ReadLine(); // Display the reversed word
        }

        
        static string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    
    }
}
