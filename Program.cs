using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        for (int i = 1; i <= 3; i++)
        {

            for (int j = 1; j <= i; j++)
            { 
           Console.Write(j); 
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }

    
         
}