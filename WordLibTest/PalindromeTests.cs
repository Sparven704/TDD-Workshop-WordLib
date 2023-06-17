using Xunit;
using WordLib;

namespace WordLibTest
{
    public class PalindromeTests
    {
        // Test to see if a word is a palindrome, should return a true 
        [Fact]
        public void IsPalindrome_ShouldReturnTrue_ForPalindromeWord()
        {
          
            string word = "Madam";
            var funWithWords = new FunWithWords();

            var result = funWithWords.IsPalindrome(word);

        
            Assert.True(result);
        }

        // Test to see if a word is a plaindrome, should return false
        [Fact]
        public void IsPalindrome_ShouldReturnFalse_ForNonPalindromeWord()
        {
           
            string word = "Sparven";
            var funWithWords = new FunWithWords();

            var result = funWithWords.IsPalindrome(word);

           
            Assert.False(result);
        }

        // Test to see if a bool is being returned by function IsPalindrome
        [Fact]
        public void IsPalindrome_ShouldReturnABool()
        {

            string word = "Level";
            var funWithWords = new FunWithWords();

            var result = funWithWords.IsPalindrome(word);


            Assert.IsType<bool>(result);
        }
    }

    // Tests for Letter counting function CountLettersInAWord
    public class LetterCounterTests
    {
        // Test that tests if function gives correct count
        [Fact]
        public void CountLettersInAWord_ShouldReturnCorrectLetterCount()
        {

            string word = "lilith";
            var funWithWords = new FunWithWords();

            int expected = 6;

            var result = funWithWords.CountLettersInAWord(word);

            
            Assert.Equal(expected, result);
        }

        // Test that further tests that function gives correct count
        [Fact]
        public void CountLettersInAWord_LetterCountsShouldBeNotEqual()
        {
            string word = "morgoth";
            var funWithWords = new FunWithWords();

            int wrongCount = 4;

            var result = funWithWords.CountLettersInAWord(word);

            Assert.NotEqual(wrongCount, result);
        }

        // Test that makes sure function returns a int
        [Fact]
        public void CountLettersInAWord_CheckIfReturnsInt()
        {
            string word = "bird";
            var funWithWords = new FunWithWords();

            var result = funWithWords.CountLettersInAWord(word);

            Assert.IsType<int>(result);
        }
    }
}
