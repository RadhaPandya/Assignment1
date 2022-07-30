/*Write a C# program to convert from celsius degrees to Kelvin and Fahrenheit.
Test Data:
Enter the amount of celsius: 30
Expected Output:
Kelvin = 303
Fahrenheit = 86*/

using System;

class Program14
{
    static void Main()
    {
        Console.Write("Enter the amount of celsius :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Kelvin :{0}",(a+273.15));
        Console.WriteLine("Fahrenheit:{0}",(a*9/5)+32);
    }
}