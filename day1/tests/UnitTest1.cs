using System;
using Xunit;
using Xunit.Abstractions;
using AdventOfCode;
using FluentAssertions;

namespace tests;

public class UnitTest1
{
    public static readonly string Sample = @"199
200
208
210
200
207
240
269
260
263";

    [Fact]
    public void Test1()
    {
        var expected = 7;
        var actual = Day1.GetStar1(Sample);
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test2()
    {
        var expected = 5;
        var actual = Day1.GetStar2(Sample);
        Assert.Equal(expected, actual);
    }
}