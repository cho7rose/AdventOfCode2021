using System;
using Xunit;
using Xunit.Abstractions;
using AdventOfCode;
using FluentAssertions;

namespace tests;

public class UnitTest1
{
    public static readonly string Sample = @"forward 5
down 5
forward 8
up 3
down 8
forward 2";
    [Fact]
    public void Test1()
    {
        var expected = 150;
        var actual = day2.GetStar1(Sample);
        Assert.Equal(expected, actual);
    }
    [Fact]
    public void Test2()
    {
        var expected = 900;
        var actual = day2.GetStar2(Sample);
        Assert.Equal(expected, actual);
    }
}