using Xunit;
using AdventOfCode;

namespace tests_day3;

public class UnitTest1
{
    public static readonly string Sample = @"00100
11110
10110
10111
10101
01111
00111
11100
10000
11001
00010
01010";
    [Fact]
    public void Test1()
    {
        var expected = 198;
        var actual = day3.GetStar1(Sample);
        Assert.Equal(actual, expected);
    }
    [Fact]
    public void Test2()
    {
        var expected = 230;
        var actual = day3.GetStar2(Sample);
        Assert.Equal(actual, expected);
    }
}