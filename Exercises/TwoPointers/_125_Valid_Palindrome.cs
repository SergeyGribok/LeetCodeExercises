namespace LeetCodeExercises;
/*
 A phrase is a palindrome if, after converting all uppercase letters into lowercase letters 
and removing all non-alphanumeric characters, it reads the same forward and backward. 
Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

Constraints:
1 <= s.length <= 2 * 105
s consists only of printable ASCII characters.
 */
internal class _125_Valid_Palindrome
{
    public static bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i < j)
        {
            var iChar = (int)s[i];

            if(!(iChar >= 48 && iChar <= 57 || iChar >= 65 && iChar <= 90 || iChar >= 97 && iChar <= 122)) 
            {
                i++;
                continue;
            }

            if (iChar >= 65 && iChar <= 90) 
                iChar = 97 - 65 + iChar;

            var jChar = (int)s[j];
            
            if (!(jChar >= 48 && jChar <= 57 || jChar >= 65 && jChar <= 90 || jChar >= 97 && jChar <= 122))
            {
                j--;
                continue;
            }

            if (jChar >= 65 && jChar <= 90)
                jChar = 97 - 65 + jChar;

            if (iChar != jChar)
                return false;

            i++;
            j--;
        }

        return true;
    }

    public static void RunSolution(string s)
    {
        Console.WriteLine("=======_125_Valid_Palindrome=========");
        Console.WriteLine("String: " + s);
        var result = IsPalindrome(s);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
