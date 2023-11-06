namespace Leetcode_Problems
{
    internal class Longest_Common_Prefix
    {
        public string Run(string[] strs)
        {
            string p = strs[0];

            // for every character in string[i], remove last character until string[i] ends
            for (int sI = 0; sI < strs.Length; sI++)
                for (int cI = 0; cI < strs[sI].Length; cI++)
                {
                    if (!strs[sI].StartsWith(p))
                        p = p[..^1];
                }

            return p;
        }
    }
}
