/*Write a C# Sharp program that takes four numbers as input to calculate and print the average.
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the four number: 30
Expected Output:
The average of 10 , 15 , 20 , 30 is: 18*/

using System;

class Program9
{
    static void Main()
    {
        Console.Write("Enter the First number :");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Second number :");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Third number :");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Forth number :");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The average of {0},{1},{2},{3} is :{4}",a,b,c,d,((a+b+c+d)/4));
    }
}