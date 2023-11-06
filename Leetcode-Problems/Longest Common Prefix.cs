namespace Leetcode_Problems
{
    internal class Longest_Common_Prefix
    {
        public string Run(string[] strs)
        {
            string p = string.Empty;

            for (int sI = 0; sI < strs.Length; sI++)
            {
                if (!strs[sI].StartsWith(p) && p.Any())
                    p = p[..^1];

                if (sI != strs.Length - 1)
                    for (int cI = 0; cI < strs[sI].Length; cI++)
                    {
                        if (strs[sI][cI] == strs[sI + 1][cI])
                            p += strs[sI][cI];
                    }
            }

            return p;
        }
    }
}
