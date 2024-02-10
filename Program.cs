using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    { 
        int sum = 0;
        int[] arr = { 1, 2, 3, 4, 5 };
         for ( int i = 0; i <=4 ; i++ )
        {
             sum += arr[i];     
        }
        Console.WriteLine(sum);

        Console.ReadLine();
    }
    }