namespace Leetcode_Problems
{
    internal class Longest_Common_Prefix
    {
        public string Run(string[] strs)
        {
            return string.Empty;

            /// TODO: 11/24/2023 - took too long

            string m = strs[0];

            for (int sI = 0; sI < strs.Length; sI++)
            {
                for (int cI = 0; cI < strs[sI].Length; cI++)
                {
                    try { }
                    catch (IndexOutOfRangeException)
                    {
                        // end loop for current word
                        break;
                    }
                }
            }

            return m;
        }
    }
}
