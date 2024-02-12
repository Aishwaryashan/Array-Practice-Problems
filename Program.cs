using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        int a = 0;
        int b = 0;
        int sum = 0;
        for (int i = 0; i <= 30; i++)
        {
            a = i % 3;
            b = i % 5;

            if (a == 0 || b == 0)
            {
                Console.Write("{0}\t", i);
                sum += i;

            }

        }
        Console.WriteLine("\n The Sum is equal to:"+sum);
        Console.ReadLine();
    }
           
        

       

       
    }



