using System;
using System.Linq;


 class pro32
    static void Main()
    {
        string str;
        Console.Write("Input a string : ");
        str = Console.ReadLine();
        Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
    }
}
