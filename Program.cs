using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {

        int[] arr = { 4, 1, 3, 5, 8, 9 };
        int max=arr[0];
        for (int i = 0; i <arr.Length;i++)
        {
            if (arr[i]>max)
            {
                max=arr[i];
            }
        }
        Console.WriteLine(max);
        
        Console.ReadLine();
    }
    }