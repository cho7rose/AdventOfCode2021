using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode;

public class day2
{
    public static int GetStar1(string raw)
    {
        string[] input = raw.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        int horizontal, depth;
        horizontal = 0;
        depth = 0;
        foreach(var s in input)
        {
            var tmp = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            switch (tmp.First())
            {
                case "forward":
                horizontal += int.Parse(tmp.Skip(1).First());
                break;

                case "up":
                depth -= int.Parse(tmp.Skip(1).First());
                break;

                case "down":
                depth += int.Parse(tmp.Skip(1).First());
                break;

                default:
                break;
            }
        }
        Console.WriteLine("The multiplication of the horizontal position and depths is {0}", (horizontal*depth).ToString());
        return horizontal*depth;
    }
        public static int GetStar2(string raw)
        {
        string[] input = raw.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        int horizontal, depth, aim;
        horizontal = 0;
        depth = 0;
        aim = 0;
        foreach(var s in input)
        {
            var tmp = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            switch (tmp.First())
            {
                case "forward":
                horizontal += int.Parse(tmp.Skip(1).First());
                depth += int.Parse(tmp.Skip(1).First())*aim;
                break;

                case "up":
                aim -= int.Parse(tmp.Skip(1).First());
                break;

                case "down":
                aim += int.Parse(tmp.Skip(1).First());
                break;

                default:
                break;
            }
        }
        Console.WriteLine("The REVISED multiplication of the horizontal position and depths is {0}", (horizontal*depth).ToString());
        return horizontal*depth;        }

}
