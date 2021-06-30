using Xunit;

namespace Ohce
{
   public class WordTest
   {
      [Theory]
      [InlineData("josepo", "opesoj")]
      [InlineData("a", "a")]
      [InlineData("ab", "ba")]
      public void Reverse(string input, string expected)
      {
         Word word = new Word(input);

         Assert.Equal(expected, word.Reverse().ToString());
      }


      [Theory]
      [InlineData("a")]
      [InlineData("aa")]
      [InlineData("sarabaras")]
      public void Palindrome(string input)
      {
         Word word = new Word(input);

         Assert.True(word.IsAPalindrome());
      }


      [Theory]
      [InlineData("ab")]
      [InlineData("josepo")]
      public void NotAPalindrome(string input)
      {
         Word word = new Word(input);

         Assert.False(word.IsAPalindrome());
      }
   }
}