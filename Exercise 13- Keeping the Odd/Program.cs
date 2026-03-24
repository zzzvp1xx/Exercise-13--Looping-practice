using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;

namespace Exercise_13__Keeping_the_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //set up list
            List<int> list = new List<int>();

            // Problem 1 - Populate and print numbs 1-10
            for (int i = 1; i < 11; i++) 
            {
                list.Add(i);    
                Console.WriteLine(i);
               
            }
            Console.WriteLine();
            // Problem 2 - Use a backwards for loop to remove even numbers from the list

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 == 0)
                {
                    list.RemoveAt(i); // removes the value at i's exact position
                    
                }     
            }
            //print odd numbs 1 3 5 7 9           
            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine(list[i]);
               
            }
            Console.WriteLine();

            // Problem 3 

            List<int> numbers = new List<int>(); //set up list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            
            for (int i = 0; i < numbers.Count; i++) 
            {
                if (numbers[i] == 1 || numbers[i] == 3)
                {
                    numbers.RemoveAt(i);
                    
                }
            }
           foreach (int i in numbers)
           {
                Console.WriteLine(i);
               
           }
        }     
    }
}