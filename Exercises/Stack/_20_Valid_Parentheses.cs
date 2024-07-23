using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace LeetCodeExercises;
/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.

Constraints:
1 <= s.length <= 10^4
s consists of parentheses only '()[]{}'.
 */
public class _20_Valid_Parentheses
{
    private static bool IsValid(string s)
    {
        if (s == null || s.Length == 1)
        {
            return false;
        }

        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> map = new Dictionary<char, char>
        {
            {'(' , ')'},
            {'[', ']' },
            {'{', '}' }
        };

        foreach (char letter in s)
        {
            if (map.ContainsKey(letter))
            {
                stack.Push(letter);
            }

            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char open = stack.Pop();
                char value = map[open];
                if (value != letter)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
    private static bool IsValid_WithStaack(string s)
    {
        if (s.Length == 1)
        {
            return false;
        }
        Dictionary<char, char> mapping = new()
        {
            {'(' , ')'},
            {'[', ']' },
            {'{', '}' }
        };

        Stack<char> stack = new Stack<char>();

        foreach (var c in s)
        {
            if(mapping.ContainsKey(c))
            {
                stack.Push(c);
            }
            else 
            {
                if (stack.TryPop(out char b))
                {
                    if (c != mapping[b])
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        if(stack.Count > 0)
        {
            return false;
        }
        return true;
    }

    public static void RunSolution(string s)
    {
        Console.WriteLine("=======_20_Valid_Parentheses=========");
        Console.WriteLine("String: " + s);
        var result = IsValid(s);
        Console.WriteLine("Result = " + result);
        Console.WriteLine(new string('=', 60));
    }
}
