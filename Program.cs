using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        int mul = 1;

        for (int i = 10; i >= 1; i--)
        {
            mul *= i;
        }
        Console.WriteLine(mul);

        Console.ReadLine();
    }
    }