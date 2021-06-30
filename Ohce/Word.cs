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
         return false;
      }

      public override string ToString()
      {
         return _word;
      }
   }
}