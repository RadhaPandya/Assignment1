/*Write a C# program that takes a number as input and then displays a rectangle of 3 columns
wide and 5 rows tall using that digit.
Test Data:
Enter a number: 5
Expected Output:
555
5 5
5 5
5 5
555*/

using System;

class Program13
{
    static void Main()
    {
        Console.Write("Enter a number :");
        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 5; i++)
        {
            if (i==1 || i==5)
            {
                Console.WriteLine("{0}{0}{0}", a);
            }
            else
            {
                Console.WriteLine("{0} {0}", a);
            }
        }
    }
}