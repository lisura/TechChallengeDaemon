using System;
using System.Collections.Generic;

namespace DaemonChallengeQuestions
{
    public static class SortArrayWaveForm
    {
        public static int[] Execute(int[] arr)
        {
            var result = new List<int>();
            var halfArraySize = arr.Length / 2;
            Array.Sort(arr);
            Array.Reverse(arr);
            for (int i = 0 ; i < arr.Length - halfArraySize; i++)
            {
                result.Add(arr[i]);
                result.Add(arr[i + halfArraySize]);
            }
            return result.ToArray();
        }
    }
}
