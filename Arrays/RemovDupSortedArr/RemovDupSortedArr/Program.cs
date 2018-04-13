using System;

namespace RemovDupSortedArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0,0,0, 1, 1, 1,3,3};
            int[] retArray = new int[nums.Length];
            Console.WriteLine("Before:");

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
            int wrtr = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (!(nums[i] == nums[i + 1]))
                {
                    retArray[wrtr++] = nums[i];
                }
            }
            retArray[wrtr++] = nums[nums.Length - 1];
            Console.WriteLine("After:");
            for (int i = 0; i < wrtr; i++)
            {
                Console.WriteLine(retArray[i]);
            }
        }
    }
}
