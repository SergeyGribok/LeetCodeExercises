namespace LeetCodeExercises;
/*
 Given a string s consisting of words and spaces, return the length of the last word in the string.

A word is a maximal substring consisting of non-space characters only.
*/
internal class _58_Length_of_Last_Word
{
    public static int LengthOfLastWord(string s)
    {
        int count = 0;
        
        for(int i = s.Length - 1; i >= 0; i--)
        {
            if (char.IsWhiteSpace(s[i]))
            {
                if(count > 0)
                    break;
            }
            else
            {
                count++;
            }
            
        }
        return count;
    }

    public static void RunSolution(string s)
    {
        Console.WriteLine("=======_58_Length_of_Last_Word=========");
        Console.WriteLine("Sentence: " + s);
        var result = LengthOfLastWord(s);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
