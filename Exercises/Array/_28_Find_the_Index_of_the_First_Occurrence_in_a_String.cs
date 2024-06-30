namespace LeetCodeExercises;
/*Given two strings needle and haystack, 
 * return the index of the first occurrence of needle in haystack, 
 * or -1 if needle is not part of haystack.

Example 1:

Input: haystack = "sadbutsad", needle = "sad"
Output: 0
Explanation: "sad" occurs at index 0 and 6. The first occurrence is at index 0, so we return 0.*/
internal class _28_Find_the_Index_of_the_First_Occurrence_in_a_String
{
    /// <summary>
    /// KMP Algorithm. Complexity Time O(m+n)
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns></returns>
    public static int StrStr(string haystack, string needle)
    {
        int H = haystack.Length;
        int N = needle.Length;

        computeLPSArray(needle, N, out int[] lps);

        int i = 0;
        int j = 0;

        while((H - i) >= (N - j))
        {
            var n = needle[j];
            var h = haystack[i];
            if (needle[j] == haystack[i])
            {
                j++;
                i++;
            }

            if(j == N)
            {
                return i - j;
            }
            else if(i < H && needle[j] != haystack[i])
            {
                if (j != 0)
                    j = lps[j - 1];
                else
                    i = i + 1;
            }
        }

        return -1;
    }

    static void computeLPSArray(string pattern, int patternLength, out int[] lps)
    {
        lps = new int[patternLength];

        int len = 0;
        int i = 1;
        lps[0] = 0;

        while(i < patternLength)
        {
            if (pattern[i] == pattern[len])
            {
                len++;
                lps[i] = len;
                i++;
            }
            else
            {
                if(len != 0)
                {
                    len = lps[len - 1];
                }
                else
                {
                    lps[i] = len;
                    i++;
                }
            }
        }
    }

    /// <summary>
    /// Time - O((H-N)N)
    /// </summary>
    /// <param name="haystack"></param>
    /// <param name="needle"></param>
    /// <returns></returns>
    public static int StrStr_Naive(string haystack, string needle)
    {
        if (haystack.Length == 0 || needle.Length == 0) return -1;
        int H = haystack.Length;
        int N = needle.Length;

        for (int i = 0; i <= H - N; i++)
        {
            int j;
            for (j = 0; j < N; j++)
            {
                if (haystack[i + j] != needle[j])
                    break;
            }

            if (j == N)
                return i;
        }

        return -1;
    }
    public static void RunSolution(string haystack, string needle)
    {
        Console.WriteLine("=======_28_Find_the_Index_of_the_First_Occurrence_in_a_String=========");
        Console.WriteLine("Haystack: " + haystack);
        Console.WriteLine("Needle: " + needle);
        var result = StrStr(haystack, needle);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
