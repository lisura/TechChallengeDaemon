using System;

namespace DaemonChallengeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tech Challenge Daemon \n");

            Console.WriteLine("Question 1 - Check if two arrays are equal or not");
            Console.WriteLine(CheckTwoArraysAreEqual.Execute(new int[] { 1, 7, 1 }, new int[] { 7, 7, 1 }));
            Console.WriteLine(" \n");

            Console.WriteLine("Question 2 - Stock Buy Sell to Maximize Profit");
            foreach (var tuple in StockBuySell.Execute(new int[] { 100, 180, 260, 310, 40, 535, 695 }))
            {
                Console.WriteLine($"BUY {tuple.Item1} - SELL {tuple.Item2}");
            }
            Console.WriteLine(" \n");

            Console.WriteLine("Question 3 -Sort an array in wave form");
            Console.WriteLine(String.Join(',',SortArrayWaveForm.Execute(new int[] { 20, 10, 8, 6, 4, 2 })));
        }
    }
}
