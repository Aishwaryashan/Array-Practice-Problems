using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        int  a = 2;
        bool b = false;
        int[] arr = { 4, 7,3,1,22,6 };

        for (int i = 0; i <= 5; i++)
        {
            if (arr[i] == a)
            {
                b = true;
               
            }
            
        }
        if(b)
        {
            Console.WriteLine($"{a} is present");
        }
        else
        {
            Console.WriteLine($"{a} is not present");

        }
       
        Console.ReadLine();
    }
    }