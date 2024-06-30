namespace LeetCodeExercises;
/*
 * Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string 
by deleting some (can be none) of the characters without disturbing the relative positions 
of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
Constraints:

0 <= s.length <= 100
0 <= t.length <= 104
s and t consist only of lowercase English letters.
 */
internal class _392_Is_Subsequence
{
    public static bool IsSubsequence(string s, string t)
    {
        if(s.Length == 0) return true;

        int sI = 0;

        for(int i = 0; i < t.Length; i ++)
        {
            if(s[sI] == t[i])
            {
                sI++;
            }
            if (sI == s.Length)
                return true;
        }

        return false;
    }

    public static void RunSolution(string s, string t)
    {
        Console.WriteLine("=======_392_Is_Subsequence=========");
        Console.WriteLine("Test: " + t);
        Console.WriteLine("Subsequence: " + s);
        var result = IsSubsequence(s, t);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }

}

