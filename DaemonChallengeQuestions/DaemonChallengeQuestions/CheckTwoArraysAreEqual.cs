using System;
using System.Linq;

namespace DaemonChallengeQuestions
{
    static public class CheckTwoArraysAreEqual
    {
        public static string Execute(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);
            if (arr1.SequenceEqual(arr2))
            {
                return "Yes";
            }
            return "No";
        }

    }
}
