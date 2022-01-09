using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode;
public class day4
{
    public static int GetStar1(string raw)
    {
        string[] input = raw.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        int[] draw = Array.ConvertAll(input[0].Split(","), int.Parse);
        string[] better_boards = raw.Split(new[] {Environment.NewLine + Environment.NewLine }, StringSplitOptions.None);
        better_boards = better_boards.Skip(1).ToArray();
        var ListOfBoards = new List<string[]>();
        foreach(var b in better_boards)
        {
            string[] board = b.Split("\r\n");
            ListOfBoards.Add(board);
        }
        int result = GetWinner(draw, ListOfBoards);
        Console.WriteLine("The result is: {0}", result);
        return result;
    }
    public static int GetStar2(string raw)
    {
        string[] input = raw.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
        int[] draw = Array.ConvertAll(input[0].Split(","), int.Parse);
        string[] better_boards = raw.Split(new[] {Environment.NewLine + Environment.NewLine }, StringSplitOptions.None);
        better_boards = better_boards.Skip(1).ToArray();
        var ListOfBoards = new List<string[]>();
        foreach(var b in better_boards)
        {
            string[] board = b.Split("\r\n");
            ListOfBoards.Add(board);
        }
        var result = GetLastWinner(draw, ListOfBoards);
        Console.WriteLine("Second star is: {0}", result);
        return result;
    }
    public static int GetWinner(int[] draw, List<string[]> ListOfBoards)
    {
        int winningNumber = 0;
        for(int d = 5; d<draw.Length; d++)
        {
            var tmp_draw=draw.ToList().Take(d).ToArray();
            foreach(var board in ListOfBoards)
            {
                winningNumber=isWinningBoard(board,tmp_draw);
                if(winningNumber!=0) return winningNumber;
            }
        }
        return 0;
    }
    public static int GetLastWinner(int[] draw, List<string[]> ListOfBoards)
    {
        int winningNumber = 0;
        var ListOfResults = new Dictionary<string[], int>();
        for(int d = 5; d<draw.Length; d++)
        {
            var tmp_draw=draw.ToList().Take(d).ToArray();
            foreach(var board in ListOfBoards)
            {
                winningNumber=isWinningBoard(board,tmp_draw);
                if(winningNumber!=0 && !ListOfResults.ContainsKey(board)) ListOfResults.Add(board, winningNumber);
            }
        }
        return ListOfResults.Last().Value;
    }
    public static int isWinningBoard(string[] board, int[] tmp_draw)
    {
        bool winnerRow = false;
        int sumOfBoard = 0;
        foreach(var line in board)
        {
            int[] tmp=Array.ConvertAll(line.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
            sumOfBoard += tmp.Sum();
            foreach(var el in tmp)
            {
                sumOfBoard -= tmp_draw.Contains(el)?el:0;
            }
            if(tmp_draw.Contains(tmp[0]) && tmp_draw.Contains(tmp[1]) && tmp_draw.Contains(tmp[2]) && tmp_draw.Contains(tmp[3]) && tmp_draw.Contains(tmp[4]))
            {
                winnerRow=true;
            }
        }


        //Search in Columns
        string[] transposed = new string[5] ;
        for(int i=0; i<5; i++)
            {
                foreach(var line in board)
                {
                    int[] tmp=Array.ConvertAll(line.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
                    transposed[i]+=tmp[i]+" ";

                }
            }
        bool WinnerColumn = false;
        int sumOfBoardColumns = 0;
        foreach(var line in transposed)
        {
            int[] tmp=Array.ConvertAll(line.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
            sumOfBoardColumns += tmp.Sum();
            foreach(var el in tmp)
            {
                sumOfBoardColumns -= tmp_draw.Contains(el)?el:0;
            }
            if(tmp_draw.Contains(tmp[0]) && tmp_draw.Contains(tmp[1]) && tmp_draw.Contains(tmp[2]) && tmp_draw.Contains(tmp[3]) && tmp_draw.Contains(tmp[4]))
            {
                WinnerColumn=true;
            }
        }


        if(winnerRow==true) 
        {
            return (sumOfBoard*tmp_draw.Last());
        }
        else if(WinnerColumn == true)
        {
            return (sumOfBoardColumns*tmp_draw.Last());
        }
        else
        {
            return 0;
        }
    }

}
