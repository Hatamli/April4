using April4.Model;
using System;

namespace April4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 3, 5, 13, 8 };

            Sort.CustomSort(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
