using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        int x = 14;
        int y = x % 2;
        if (y == 0)
        {
            Console.WriteLine("Its even");
        }
        else
        {
            Console.WriteLine("Not an even number");
        }
        Console.ReadLine();
    }
 }