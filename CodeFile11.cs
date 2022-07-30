/*Write a C# Sharp program that takes an age (for example 20) as input and prints something
as "You look older than 20".
Test Data:
Enter your age – 25
Expected Output:
You look older than 25*/

using System;

class Program11
{
    static void Main()
    {
        Console.Write("Enter the age :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("You look older than {0}",a);
    }
}