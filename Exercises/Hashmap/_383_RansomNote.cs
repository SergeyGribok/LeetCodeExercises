namespace LeetCodeExercises;
/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed
by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.
Constraints:

1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.

 */
internal class _383_RansomNote
{
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        int[] table = new int[26];

        for(int i = 0; i < magazine.Length; i++)
        {
            table[magazine[i] - 'a']++;
        }

        for(int i = 0; i < ransomNote.Length; i++)
        {
            if (table[ransomNote[i] - 'a'] == 0)
                return false;

            table[ransomNote[i] - 'a']--;
        }

        return true;
    }

    public static void RunSolution(string ransomNote, string magazine)
    {
        Console.WriteLine("=======_383_RansomNote=========");
        Console.WriteLine("ransomNote: " + ransomNote);
        Console.WriteLine("magazine: " + magazine);
        var result = CanConstruct(ransomNote, magazine);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
