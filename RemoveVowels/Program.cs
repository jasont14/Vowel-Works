

/*
 * VowelWorks.cs
 * J.Thatcher
 * Class, Methods, Fields, Properties, Arrays, char, foreach, for
*/ 

using System;

namespace VowelWork
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";

            Console.Write("Enter a short phrase below:\n\n ");
            text = Console.ReadLine();
            Console.Write("\n");

            Console.Clear();

            VowelsWorked VW = new VowelsWorked(text);            
            Console.WriteLine("Original String: \'" + text + "\'");
            Console.Write("\n");
            Console.Write("\n");

            Console.WriteLine("Contains Vowels?: " + VW.DoesStringContainVowels(text).ToString());            
            Console.WriteLine("Total Number of Vowels: " + VW.TotalNumberOfVowels);
            Console.Write("\n");

            Console.WriteLine("Number of A's: " + VW.NumberOfA);
            Console.WriteLine("Number of E's: " + VW.NumberOfE);
            Console.WriteLine("Number of I's: " + VW.NumberOfI);
            Console.WriteLine("Number of O's: " + VW.NumberOfO);
            Console.WriteLine("Number of U's: " + VW.NumberOfU);
            Console.Write("\n");

            Console.WriteLine("Original String rewritten with vowels removed: " + VW.StringWithVowelsRemoved(text));
            Console.ReadLine();
        }


    }
}
