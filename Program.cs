using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        for(int i=1; i<=4; i++)
        {
            for (int j = 4; j>=i; j--)
            { 
                Console.Write("*");
            }
        Console.WriteLine();
        }
        Console.ReadLine();
    }

    
         
}