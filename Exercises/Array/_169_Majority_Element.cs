namespace LeetCodeExercises;


/*
 * Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. 
You may assume that the majority element always exists in the array.
*/
internal class _169_Majority_Element
{
    public static int MajorityElement(int[] nums)
    {
        Dictionary<int, int> countMajority = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if (countMajority.ContainsKey(num))
            {
                countMajority[num]++;
            }
            else
            {
                countMajority[num] = 1;
            }

            if (countMajority[num] > nums.Length / 2)
            {
                return num;
            }
        }
        return -1;
    }
    public static int MajorityElement_FirstTry(int[] nums)
    {
        if (nums.Length == 0) return 0;
        
        Dictionary<int, int> countMajority = new Dictionary<int, int>();
        
        for(int i = 0; i < nums.Length; i++ )
        {
            if (countMajority.ContainsKey(nums[i]))
                countMajority[nums[i]] += 1;
            else
                countMajority.Add(nums[i], 1);
        }

        return countMajority.MaxBy(x => x.Value).Key;
    }

    public static void RunSolution(int[] nums)
    {
        Console.WriteLine("=======_169_Majority_Element=========");
        nums.PrintArray("array:");
        var result = MajorityElement(nums);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
