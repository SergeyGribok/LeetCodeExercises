namespace LeetCodeExercises;
/*
 * Given an array of integers nums and an integer target,
 * return indices of the two numbers such that they add up to target.

You may assume that each input would have exactly one solution, 
and you may not use the same element twice.

You can return the answer in any order.

Constraints:

2 <= nums.length <= 10^4
-10^9 <= nums[i] <= 10^9
-10^9 <= target <= 10^9
Only one valid answer exists.
 */
public class _1_Two_Sum
{
    public static int[] TwoSum(int[] nums, int target)
    {

        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }

        return [0, 0];
    }

    public static int[] TwoSum_Naive(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return [i, j];
            }
        }

        return [0, 0];
    }

    public static void RunSolution(int[] nums, int target)
    {
        Console.WriteLine("=======_1_Two_Sum=========");
        nums.PrintArray();
        Console.WriteLine("target: " + target);
        var result = TwoSum(nums, target);
        result.PrintArray("Result: ");
        Console.WriteLine(new string('=', 60));
    }
}
