using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {

            int x = i;
            for (int j = 1; j <=i; j++)
            {
                Console.Write(x);
                x++;
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }



}