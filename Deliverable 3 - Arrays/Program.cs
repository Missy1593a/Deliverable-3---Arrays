/*
    Author: Amrita Amnay
    Date: 9/17/2019
    Comments: This C# Console application code demonstrates the use of
              Arrays
*/
using System;
using System.Linq;
namespace Deliverable_3___Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int[] arr1 = Enumerable.Range(1, 25).ToArray();
                foreach (int i in arr1)
                { 
                    Console.WriteLine("Element Value = " + i);
                }
            }
        }      
    }
}

