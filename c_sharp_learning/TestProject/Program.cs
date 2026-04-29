using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class MainClass
{
    public static void Main(string[] args)
    {
        string test = "кгуде";
        string test_sorted = new string(test.OrderByDescending(x => x).ToArray());
        Console.WriteLine(test_sorted);
    }
}