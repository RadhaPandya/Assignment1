/*Write a C# Sharp program to print the output of multiplication of three numbers which will be
entered by the user.
Test Data:
Input the first number to multiply: 2
Input the second number to multiply: 3
Input the third number to multiply: 6
Expected Output:
2 x 3 x 6 = 36
Core 12: Programming with C#.NET | Atmiya University 2 | P a g e*/

using System;

class Program6
{
    static void Main()
    {
        Console.Write("Input the First number to multiply :");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the Second number to multiply :");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the Third number to multiply :");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("{0}*{1}*{2} = {3}",a,b,c,(a*b*c));
    }
}