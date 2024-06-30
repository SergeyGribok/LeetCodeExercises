using System.Diagnostics;

namespace LeetCodeExercises;
/*
 Given an integer array nums sorted in non-decreasing order, 
remove the duplicates in-place such that each unique element appears only once. 
The relative order of the elements should be kept the same. 
Then return the number of unique elements in nums.

Consider the number of unique elements of nums to be k, to get accepted, 
you need to do the following things:

Change the array nums such that the first k elements of nums
contain the unique elements in the order they were present in nums initially. 
The remaining elements of nums are not important as well as the size of nums.
Return k.

Constraints:

1 <= nums.length <= 3 * 104
-100 <= nums[i] <= 100
nums is sorted in non-decreasing order.
 */
internal class _26_Remove_Duplicates_from_Sorted_Array
{
    public static int RemoveDuplicates(int[] nums)
    {
        int prevVal = nums[0];
        int lastIndex = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (prevVal != nums[i])
            {
                lastIndex++;
                nums[lastIndex] = nums[i];

                prevVal = nums[i];
            }
        }

        return lastIndex + 1;
    }

    public static void RunSolution(int[] nums)
    {
        Console.WriteLine("=======_26_Remove_Duplicates_from_Sorted_Array=========");
        nums.PrintArray("Before:");
        var result = RemoveDuplicates(nums);
        Console.WriteLine("Result = " + result);
        nums.PrintArray("After:");
        Console.WriteLine(new string('=', 60));
    }
}
