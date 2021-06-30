using System;

namespace Ohce
{
   class Program
   {
      static void Main(string[] args)
      {
         Word word = new Word(args[0]);

         Console.WriteLine(word.Reverse());

         if (word.IsAPalindrome())
            Console.WriteLine("Nice word!");
      }
   }
}
