using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode;

public class day3
{
    public static int GetStar1(string raw)
    {
        string[] input = raw.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        string gamma = GetGamma(input);
        string epsilon = GetEpsilon(gamma);
        int result = Convert.ToInt32(gamma,2)*Convert.ToInt32(epsilon,2);
        Console.WriteLine("Star1 is: {0}", result);
        return result;
    }
    public static string GetGamma(string[] input)
    {
        string[] transposed = new string[input[0].Length];
        string myGamma = "";
        for(int i=0; i<input[0].Length; i++)
            {
                foreach(var s in input)
                {
                    transposed[i]+=s[i];

                } 
                myGamma+=(transposed[i].Count(n=>n=='0')>transposed[i].Length/2 ? '0' : '1');
            }
        return myGamma;
    }
    public static string GetEpsilon(string gamma)
    {
        string myEpsilon = "";
        foreach (var c in gamma)
        {
            myEpsilon+=(c=='0'?'1':'0');
        }
        return myEpsilon;
    }
    public static int GetStar2(string raw)
    {
        string[] input = raw.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        string Oxygen = GetOxygenRating(input);
        string CO2 = GetCO2Rating(input);
        int result = Convert.ToInt32(Oxygen,2)*Convert.ToInt32(CO2,2);
        Console.WriteLine("Star2 is: {0}", result);
        return result;
   
    }
    public static string GetOxygenRating(string[] input)
    {
        string[] new_input = input;
        int i=0;
        while(new_input.Length > 1)
        {
            string tmp = "";
            foreach(var s in new_input)
            {
                tmp += s[i];
            }
            char mostFrequentChar = (tmp.Count(n=>n=='0')>tmp.Length/2) ? '0' : '1';
            new_input=new_input.Where(n=>n[i]==mostFrequentChar).ToArray();
            i++;
        }
        return new_input[0];
    }
    public static string GetCO2Rating(string[] input)
    {
        string[] new_input = input;
        int i = 0;
        while(new_input.Length > 1)
        {
            string tmp = "";
            foreach(var s in new_input)
            {
                tmp += s[i];
            }
            char mostFrequentChar = (tmp.Count(n=>n=='0')>tmp.Length/2) ? '1' : '0';
            {
                new_input=new_input.Where(n=>n[i]==mostFrequentChar).ToArray();
            }
            i++;
        }
        return new_input[0];
    }
}