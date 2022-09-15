using System;
using System.Linq;

namespace Reto1
{
    public class Reto1
    {
        public static bool IsValid_O_n_2(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var candidate = RemoveAt(nums, i);
                if (CheckIsIncreasing(candidate)) return true;
            }

            return false;
        }

        public static int[] RemoveAt(int[] nums, int index)
        {
            var list = nums.ToList();
            list.RemoveAt(index);
            return list.ToArray();            
        }

        public static bool CheckIsIncreasing(int[] nums)
        {
            if (nums.Length <= 1) return true;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] <= nums[i]) return false; 
            }
            return true;
        }

        public static bool IsValid_O_n(int[] nums)
        {
            bool hasBeenRemoved = false;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] >= nums[i])
                {
                    if (hasBeenRemoved) return false;

                    hasBeenRemoved = true;

                    // solves case { 1, 7, 8, 4, 9 } --> { 1, 7, 8, 8, 9 }
                    if (i >= 2 && nums[i - 2] >= nums[i])   
                        nums[i] = nums[i - 1];
                }
            }

            return true;
        }
    }
}
