/*Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of
(x+y).z and x.y + y.z.
Test Data:
Enter first number - 5
Enter second number - 6
Enter third number - 7
Expected Output:
Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72
Core 12: Programming with C#.NET | Atmiya University 3 | P a g e*/

using System;

class Program10
{
    static void Main()
    {
        Console.Write("Enter the First number :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Second number :");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Third number :");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Result of specified numbers {0}, {1} and {2}, {0}+{1}.{2} is {3} and {0}.{1} + {1}.{2} is {4}",a,b,c,((a+b)*c),((a*b)+(b*c)));
    }
}