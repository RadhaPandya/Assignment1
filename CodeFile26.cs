using System;
using System.Linq;

class Pro26
{
    static void Main()
    {
        string text = "My GirlFriend name is Natasha Patel";

        Console.WriteLine(string.Join(" ", text.Split(' ').Reverse()));
    }
}
