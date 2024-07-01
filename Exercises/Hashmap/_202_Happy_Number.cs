namespace LeetCodeExercises;
/*
 Write an algorithm to determine if a number n is happy.

A happy number is a number defined by the following process:

Starting with any positive integer, replace the number by the 
sum of the squares of its digits.
Repeat the process until the number equals 1 (where it will stay), 
or it loops endlessly in a cycle which does not include 1.
Those numbers for which this process ends in 1 are happy.
Return true if n is a happy number, and false if not.

Constraints:

1 <= n <= 2^31 - 1
 */
internal class _202_Happy_Number
{
    static bool IsHappy(int n)
    {
        HashSet<int> sums = [n];

        int sum = 0;
        int val = n;
        int resultSum = n;
        while(resultSum != 1)
        {
            int remainder = val % 10;
            
            if (val != 0)
            {
                sum += remainder * remainder;
                val = (val - remainder) / 10;
            }
            else
            {
                if (sums.Contains(sum))
                    return false;
                else
                    sums.Add(sum);

                resultSum = sum;
                val = sum;
                sum = 0;
            }

            
        }

        return true;
    }

    public static void RunSolution(int n)
    {
        Console.WriteLine("=======_202_Happy_Number=========");
        Console.WriteLine("number: " + n);
        var result = IsHappy(n);
        Console.WriteLine("Result: " + result);

        Console.WriteLine(new string('=', 60));
    }
}
