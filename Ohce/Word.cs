namespace Ohce
{
   public class Word
   {
      private readonly string _word;

      public Word(string word)
      {
         _word = word;
      }

      public Word Reverse()
      {
         return new Word(_word);
      }

      public bool IsAPalindrome()
      {
         bool palindrome = true;
         int i = 0;
         int half = _word.Length / 2;

         while (palindrome && (i <= half))
         {
            if (_word[i] != _word[_word.Length - (i + 1)])
               palindrome = false;

            i++;
         }

         return palindrome;
      }

      public override string ToString()
      {
         return _word;
      }
   }
}