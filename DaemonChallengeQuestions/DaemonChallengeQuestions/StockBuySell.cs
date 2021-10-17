using System;
using System.Collections.Generic;

namespace DaemonChallengeQuestions
{
    public static class StockBuySell
    {
        public static List<Tuple<int, int>> Execute(int[] arr)
        {

            if (IsSortedDecreasing(arr))
            {
                return null;
            }
            else
            {
                var ordersExecutionDaysList = new List<Tuple<int, int>>();
                int dayToBuy = 0;
                int dayToSell = 0;
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[dayToBuy] > arr[i])
                    {
                        dayToSell = i - 1;
                        ordersExecutionDaysList.Add(Tuple.Create(dayToBuy, dayToSell));
                        dayToBuy = i;
                    }
                    if (i == arr.Length - 1)
                    {
                        ordersExecutionDaysList.Add(Tuple.Create(dayToBuy, i));
                    }
                }
                return ordersExecutionDaysList;
            }
        }

        private static bool IsSortedDecreasing(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] < arr[i])
                {
                    return false;
                }
            }
            return true;
        }
    }

}
