using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode;

public class Day1
{
    public static int GetStar1(string raw)
    {
        double[] input = Array.ConvertAll(raw.Split(new[] { Environment.NewLine }, StringSplitOptions.None), s => double.Parse(s));
        int increases = 0;
        for(int i=1; i<input.Length; i++)
        {
            if(input[i]>input[i-1]) increases++;
        }
        Console.WriteLine("There are {0} increases", increases);
        return increases;
    }
}
