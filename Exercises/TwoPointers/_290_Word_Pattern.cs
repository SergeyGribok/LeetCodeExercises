using System.Collections.Immutable;

namespace LeetCodeExercises;
/*
Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection 
between a letter in pattern and a non-empty word in s.

Constraints:

1 <= pattern.length <= 300
pattern contains only lower-case English letters.
1 <= s.length <= 3000
s contains only lowercase English letters and spaces ' '.
s does not contain any leading or trailing spaces.
All the words in s are separated by a single space.
 */
public class _290_Word_Pattern
{
    public static bool WordPattern(string pattern, string s)
    {
        Dictionary<char, string> dict = new Dictionary<char, string>();

        string[] strings = s.Split(' ');

        if(strings.Length != pattern.Length)
            return false;
        
        for(int i = 0; i < pattern.Length; i++)
        {
            if (dict.TryGetValue(pattern[i], out var str))
            {
                if(str != strings[i])
                    return false;
                continue;
            }

            if (dict.ContainsValue(strings[i]))
                return false;

            dict.Add(pattern[i], strings[i]);
        }

        return true;

    }
    public static bool WordPattern_WithoutDictionary(string pattern, string s)
    {
        int[] pHashtable = new int[26];

        int wordCount = 0;
        int wordHash = 0;
        int wordCharCount = 0;
        for (int i = 0; i <= s.Length; i++)
        {
            if (wordCount == pattern.Length)
            {
                return false;
            }
            if (i == s.Length || s[i] == ' ')
            {
                int hash = pattern[wordCount] - 'a';
                if (pHashtable[hash] == 0)
                {
                    pHashtable[hash] = wordHash;
                }
                else if (pHashtable[hash] != wordHash)
                {
                    return false;
                }

                int j = 0;
                while (j < wordCount)
                {
                    int hash1 = pattern[j] - 'a';
                    if (hash != hash1 && pHashtable[hash1] == wordHash)
                    {
                        return false;
                    }
                    j++;
                }

                wordCount++;
                wordHash = 0;
                wordCharCount = 0;
            }
            else
            {
                wordHash += (wordCharCount + 1) * s[i];
                wordCharCount++;
            }
        }

        if (wordCount < pattern.Length)
            return false;

        return true;
    }

    public static void RunSolution(string pattern, string s)
    {
        Console.WriteLine("=======_290_Word_Pattern=========");
        Console.WriteLine("Pattern: " + pattern);
        Console.WriteLine("String: " + s);
        var result = WordPattern(pattern, s);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
