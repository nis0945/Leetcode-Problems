using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode_Problems
{
    internal class Two_Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] r = new int[2];
            int l = nums.Length,
                x,
                y;

            for (int iX = 0; iX < l; iX++)
            {
                x = nums[iX];
                // find index of current number
                var iOfX = Array.IndexOf(nums, x);

                // add it to the results
                r[0] = iOfX;

                // modify current value so that we don't get it again in the next loop
                nums[iOfX] = (int)(-x - -10000000000);

                // match it with every other number and try to find the sum
                for (int iY = 0; iY < l; iY++)
                {
                    y = nums[iY];
                    if (x + y == target)
                    {
                        // if sum is found then return the results/
                        r[1] = Array.IndexOf(nums, y);
                        return r;
                    }
                }

                // return current number to its original state before we move on
                nums[iOfX] = (int)(-x + -10000000000);
            }

            return r;
        }
    }
}
