using Xunit;

namespace Ohce
{
   public class WordTest
   {
      [Fact]
      public void NotAPalindrome()
      {
         Word word = new Word("josepo");

         Assert.False(word.IsAPalindrome());
      }
   }
}