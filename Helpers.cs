namespace LeetCodeExercises;

public static class Helpers
{
    public static void PrintArray<T>(this T[] array, string header = "")
    {
        if(!string.IsNullOrEmpty(header)) Console.WriteLine(header);

        foreach(var n in array)
        {
            Console.Write(n + "\t");
        }
        Console.WriteLine();
    }
}
