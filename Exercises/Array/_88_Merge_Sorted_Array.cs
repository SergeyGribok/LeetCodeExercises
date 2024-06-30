namespace LeetCodeExercises;

/*
 * You are given two integer arrays nums1 and nums2, sorted in non-decreasing order, 
 * and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
Merge nums1 and nums2 into a single array sorted in non-decreasing order.
The final sorted array should not be returned by the function, 
but instead be stored inside the array nums1. 
To accommodate this, nums1 has a length of m + n,
where the first m elements denote the elements that should be merged, 
and the last n elements are set to 0 and should be ignored. nums2 has a length of n.

Example 1:

Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
Output: [1,2,2,3,5,6]
Explanation: The arrays we are merging are [1,2,3] and [2,5,6].
The result of the merge is [1,2,2,3,5,6] with the underlined elements coming from nums1.
 */
public class _88_Merge_Sorted_Array
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int mLastIndex = m - 1;
        int nLastIndex = n - 1;
        int lastIndex = nums1.Length - 1;

        while(nLastIndex >= 0)
        {
            if (mLastIndex >=0 && nums1[mLastIndex] > nums2[nLastIndex])
            {
                nums1[lastIndex] = nums1[mLastIndex];
                mLastIndex--;
                lastIndex--;
            }
            else
            {
                nums1[lastIndex] = nums2[nLastIndex];
                lastIndex--;
                nLastIndex--;
            }
        }

    }

    public static void RunSolution(int[] nums1, int m, int[] nums2, int n)
    {
        Console.WriteLine("=======88_Merge_Sorted_Array=========");
        nums1.PrintArray("Initial array nums1:");
        nums2.PrintArray("Initial array nums2:");
        Merge(nums1, m, nums2, n);
        nums1.PrintArray("Result array nums1:");
        Console.WriteLine(new string('=', 60));
    }
}
