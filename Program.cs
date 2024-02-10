using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int mul = 1;

            for (int i = num; i >= 1; i--)
            {
                mul *= i;
            }
            
            Console.WriteLine(mul);  

        }
        Console.ReadLine();
    }
       
       
    }
   