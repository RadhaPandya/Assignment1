/*Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and
dividing of two numbers which will be entered by the user.
Test Data:
Input the first number: 25
Input the second number: 4
Expected Output:
25 + 4 = 29
25 - 4 = 21
25 x 4 = 100
25 / 4 = 6
25 mod 4 = 1*/

using System;

class Program7
{
    static void Main()
    {
        Console.Write("Input the First number :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the Second number :");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}+{1} = {2}", a, b, (a + b));
        Console.WriteLine("{0}-{1} = {2}", a, b, (a - b));
        Console.WriteLine("{0}*{1} = {2}", a, b, (a * b));
        Console.WriteLine("{0}/{1} = {2}", a, b, (a / b));
        Console.WriteLine("{0}mod{1} = {2}", a, b, (a % b));
    }
}