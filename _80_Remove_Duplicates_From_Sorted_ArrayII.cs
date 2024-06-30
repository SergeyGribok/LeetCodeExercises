namespace LeetCodeExercises;

/*
 Given an integer array nums sorted in non-decreasing order, 
remove some duplicates in-place such that each unique element appears at most twice. 
The relative order of the elements should be kept the same.
Since it is impossible to change the length of the array in some languages, 
you must instead have the result be placed in the first part of the array nums. 
More formally, if there are k elements after removing the duplicates, 
then the first k elements of nums should hold the final result. 
It does not matter what you leave beyond the first k elements.
Return k after placing the final result in the first k slots of nums.

Do not allocate extra space for another array. 
You must do this by modifying the input array in-place with O(1) extra memory.
 */

public class _80_Remove_Duplicates_From_Sorted_ArrayII
{
    public static int RemoveDuplicates(int[] nums)
    {
        var indexToWrite = 0;
        int numberOfOccurence = 1;
        int prevVal = nums[0];

        for (int i = 1; i < nums.Length; i++)
        {
            if (prevVal == nums[i])
            {
                numberOfOccurence++;

                if (numberOfOccurence == 2 && indexToWrite > 0)
                {
                    nums[indexToWrite] = nums[i];
                    indexToWrite++;
                }
                if (numberOfOccurence >= 3)
                {
                    if (indexToWrite == 0)
                        indexToWrite = i;
                    else
                        continue;
                }
            }
            else
            {
                numberOfOccurence = 1;
                prevVal = nums[i];
                if (indexToWrite > 0)
                {
                    nums[indexToWrite] = nums[i];
                    indexToWrite++;
                }
            }
        }

        return indexToWrite > 0 ? indexToWrite : nums.Length;
    }

    public static void RunSolution(int[] nums)
    {
        Console.WriteLine("=======80_Remove_Duplicates_From_Sorted_ArrayII=========");
        nums.PrintArray("Initial array");
        var k = RemoveDuplicates(nums);
        nums.PrintArray("Result array");
        Console.WriteLine("k = " + k);
        Console.WriteLine(new string('=', 60));
    }

    /*
     * (NOT MINE)WHAT I WAS SUPPOSED TO ACHIVE
     * 
    public int RemoveDuplicates(int[] nums)
    {
        var replaceIndex = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (replaceIndex - 2 >= 0 && nums[replaceIndex - 2] == nums[i])
            {
                continue;
            }
            nums[replaceIndex] = nums[i];
            replaceIndex++;
        }
        return replaceIndex;
    }*/
}
