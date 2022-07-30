/*Write a C# Sharp program to swap two numbers.
Test Data:
Input the First Number : 5
Input the Second Number : 6
Expected Output:
After Swapping :
First Number : 6
Second Number : 5*/

using System;

class Program5
{
    static void Main()
    {
        Console.Write("Input the First Number :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the First Number :");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("After Swapping :");
        int c = a;
        a = b;
        b=c;
        Console.WriteLine("First Number :{0}",a);
        Console.WriteLine("Second Number :{0}",b);
    }
}