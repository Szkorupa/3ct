using System;

internal static class ProgramHelpers
{
    static void Main(string[] args)
    {
        int[] zmienna = new int[10];

        for (int i = 0; i <= 10; i++)
        {
            zmienna[1] = i;
            Console.WriteLine(zmienna[i].ToString());

        }
        Console.ReadKey();
    }
}