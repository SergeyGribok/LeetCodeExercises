namespace LeetCodeExercises;
/*
 Given an integer array nums, rotate the array to the right by k steps, 
 where k is non-negative.

Constraints:

1 <= nums.length <= 10^5
-2^31 <= nums[i] <= 2^31 - 1
0 <= k <= 10^5
 */
public class _189_Rotate_Array
{
    static void Rotate(int[] nums, int k)
    {
        var len = nums.Length;
        k %= len;
        while (k > 0)
        {
            for (var i = k; i < len; i++)
            {
                var previous = i % k;
                (nums[i], nums[previous]) = (nums[previous], nums[i]);
            }

            (len, k) = (k, k - len % k);
            k %= len;
        }
    }
    
    //BackupArray
    static void Rotate_BackupArray(int[] nums, int k)
    {
        int[] backupArray = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            backupArray[(i + k) % nums.Length] = nums[i];
        }
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = backupArray[i];
        }
    }

    public static void RunSolution(int[] nums, int k)
    {
        Console.WriteLine("=======_189_Rotate_Array=========");
        Console.WriteLine("K = " + k);
        nums.PrintArray("nums Before:");
        Rotate(nums, k);
        nums.PrintArray("nums After:");
        Console.WriteLine(new string('=', 60));
    }
}
