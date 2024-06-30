namespace LeetCodeExercises;
/*
 * Given two strings s and t, return true if t is an anagram of s, 
and false otherwise.

An Anagram is a word or phrase formed by rearranging the letters of a 
different word or phrase, typically using all the original letters exactly once.

Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
 */
public class _242_Valid_Anagram
{
    public static bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length) return false;

        int[] sHash = new int[26];
        int[] tHash = new int[26];

        for(int i = 0; i < s.Length; i++)
        {
            sHash[s[i] - 'a']++;
            tHash[t[i] - 'a']++;
        }

        for(int i = 0; i < sHash.Length; i++)
        {
            if (sHash[i] != tHash[i])
                return false;
        }

        return true;
    }

    //Follow up: What if the inputs contain Unicode characters?
    //How would you adapt your solution to such a case?
    public static bool IsAnagram_FollowUp(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i]))
                map.Add(s[i], 1);
            else
                map[s[i]]++;

            var tKey = -1 * t[i];
            if (!map.ContainsKey(tKey))
                map.Add(tKey, 1);
            else
                map[tKey]++;
        }

        foreach(var key in map.Keys)
        {
            if (!map.ContainsKey(-1 * key))
                return false;
            else if (map[key] != map[-1 * key])
                return false;
        }

        return true;
    }

    public static void RunSolution(string s, string t)
    {
        Console.WriteLine("=======_290_Word_Pattern=========");
        Console.WriteLine("String 1: " + s);
        Console.WriteLine("String 2: " + t);
        var result = IsAnagram(s, t);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }

    public static void RunSolution_FollowUp(string s, string t)
    {
        Console.WriteLine("=======_290_Word_Pattern_FollowUp=========");
        Console.WriteLine("String 1: " + s);
        Console.WriteLine("String 2: " + t);
        var result = IsAnagram_FollowUp(s, t);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
