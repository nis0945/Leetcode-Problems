namespace Leetcode_Problems
{
    internal class Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            int r = 0,
                n = x,
                eN;

            while (n > 0)
            {
                eN = n % 10;
                r = (r * 10) + eN;
                n /= 10;
            }

            return r == x;
        }
    }
}
