namespace WordLib
{
    public class FunWithWords
    {
        public int CountLettersInAWord(string word)
        {
            return word.Length;
        }

        public bool IsPalindrome(string word)
        {
            var reversed = new string(word.Reverse().ToArray());
            return string.Equals(word, reversed, StringComparison.OrdinalIgnoreCase); // Using StringComparison.OrdinalIgnoreCase to ignore upper and lowecase chars 
        }
    }
}