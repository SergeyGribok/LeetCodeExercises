/*Given two strings s and t, determine if they are isomorphic.

Two strings s and t are isomorphic if the characters in s can be replaced to get t.

All occurrences of a character must be replaced with another character while preserving the 
order of characters. No two characters may map to the same character, 
but a character may map to itself.
Constraints:

1 <= s.length <= 5 * 10^4
t.length == s.length
s and t consist of any valid ascii character.*/
namespace LeetCodeExercises;

internal class _205_Isomorphic_Strings
{
    public static bool IsIsomorphic(string s, string t)
    {
        int[] s1 = new int[128];
        int[] t1 = new int[128];

        for (int i = 0; i < s.Length; i++)
        {
            int sHash = (int)s[i] % 128;
            int tHash = (int)t[i] % 128;

            if (s1[sHash] == 0)
                s1[sHash] = tHash;

            if (t1[tHash] == 0)
                t1[tHash] = sHash;

            if (s1[sHash] != tHash || t1[tHash] != sHash)
                return false;
        }

        return true;
    }

    public static void RunSolution(string s, string t)
    {
        Console.WriteLine("=======_383_RansomNote=========");
        Console.WriteLine("First string: " + s);
        Console.WriteLine("Second string: " + t);
        var result = IsIsomorphic(s, t);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
