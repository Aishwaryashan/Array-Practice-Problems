using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
public class FileStreamExample
{
    public static void Main(string[] args)
    {
        int val = 1;
        for (int i = 0 ; i <=3 ; i++)
        {

            for (int j =0 ; j<3-i ; j++)
            { 
                Console.Write(val);
                val++;
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }

    
         
}