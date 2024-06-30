namespace LeetCodeExercises;
/*Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
The order of the elements may be changed. 
Then return the number of elements in nums which are not equal to val.

Consider the number of elements in nums which are not equal to val be k, to get accepted,
you need to do the following things:

Change the array nums such that the first k elements of nums contain the elements 
which are not equal to val. The remaining elements of nums 
are not important as well as the size of nums.
Return k.

Constraints:
0 <= nums.length <= 100
0 <= nums[i] <= 50
0 <= val <= 100
 */
internal class _27_Remove_Element
{
    public static int RemoveElement(int[] nums, int val)
    {
        int length = nums.Length;
        if (length == 1 && nums[0] == val)
            return 0;

        int lastIndex = length - 1;
        int startIndex = 0;
        int k = 0;

        while (startIndex <= lastIndex)
        {
            if (nums[startIndex] == val)
            {
                if (nums[lastIndex] == val)
                {
                    lastIndex--;
                    k++;
                    continue;
                }
                nums[startIndex] = nums[lastIndex];
                startIndex++;
                lastIndex--;
                k++;
            }
            else
            {
                startIndex++;
                if (nums[lastIndex] == val)
                {
                    lastIndex--;
                    k++;
                    continue;
                }
            }
        }
        return k;
    }
    public static void RunSolution(int[] nums, int val)
    {
        Console.WriteLine("=======_27_Remove_Element=========");
        nums.PrintArray("nums:");
        Console.WriteLine("Val: " + val);
        var result = RemoveElement(nums, val);
        nums.PrintArray("nums after execution:");
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
