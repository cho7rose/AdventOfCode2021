using System;
using AdventOfCode;

class Program
    {
        static void Main (string[] args)
        {
            AdventOfCode.Day1.GetStar1(System.IO.File.ReadAllText("input.csv"));
            AdventOfCode.Day1.GetStar2(System.IO.File.ReadAllText("input.csv"));
        }
    }