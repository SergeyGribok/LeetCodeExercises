namespace LeetCodeExercises;
/*
Write a function to find the longest common prefix string amongst an array of strings.

If there is no common prefix, return an empty string "".

Constraints:
1 <= strs.length <= 200
0 <= strs[i].length <= 200
strs[i] consists of only lowercase English letters.
 */
internal class _14_Longest_Common_Prefix
{
    public static string LongestCommonPrefix(string[] strs)
    {
        string prefix = string.Empty;
        int i = 0;
        while (i < strs[0].Length)
        {
            char c = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i == strs[j].Length || strs[j][i] != c)
                    return prefix;
            }
            prefix += c;
            i++;
        }

        return prefix;
    }
    public static string LongestCommonPrefix_FirstTry(string[] strs)
    {
        if (strs.Length == 0) return "";

        int minLength = strs[0].Length;
        foreach (string str in strs)
        {
            if (str.Length < minLength)
                minLength = str.Length;
        }

        string prefix = "";


        for (int i = 0; i < minLength; i++)
        {
            var c = strs[0][i];
            for (int j = 0; j < strs.Length; j++)
            {
                if (c == strs[j][i])
                    continue;
                else
                    return prefix;
            }
            prefix += c;
        }

        return prefix;
    }
    public static void RunSolution(string[] strs)
    {
        Console.WriteLine("=======_14_Longest_Common_Prefix=========");
        strs.PrintArray("String array:");
        var result = LongestCommonPrefix(strs);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
