using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = {'a','e','i','o','u' };
            char[] punctuation = { '~','!','@','#' };

            char[] hello = "this".ToCharArray();
            string hi = "my";
            if (!hi.Contains(vowels.ToString()))
            {
                Console.WriteLine("this string does not contain a vowel");
            }

            //string subbed = hello.Substring(0, index);

            //Console.WriteLine(index);
            //Console.WriteLine(subbed);

            Console.ReadKey();
            
        }
    }
}
