/*Write a C# Sharp program that takes a number as input and print its multiplication table.
Test Data:
Enter the number: 5
Expected Output:
5 * 0 = 0
5 * 1 = 5
5 * 2 = 10
5 * 3 = 15
....
5 * 10 = 50*/

using System;

class Program8
{
    static void Main()
    {
        Console.Write("Enter the number :");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("{0} * {1} = {2}",a,i,(a*i));
        }
    }
}