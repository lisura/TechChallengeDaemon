using DaemonChallengeQuestions;
using NUnit.Framework;
using System;

namespace DaemonChallengeQuestionsTests
{
    public class StockBuySellTests
    {
        [Test]
        public void When_CallExecuteMethodWithUnsortedArray_ReturnValidTuples()
        {
            //Arrange 
            var arr = new int[] { 100, 180, 260, 310, 40, 535, 695 };
            var validTuple01 = Tuple.Create(0, 3);
            var validTuple02 = Tuple.Create(4, 6);

            //Act
            var daysList = StockBuySell.Execute(arr);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.AreEqual(daysList[0].Item1, validTuple01.Item1);
                Assert.AreEqual(daysList[0].Item2, validTuple01.Item2);
                Assert.AreEqual(daysList[1].Item1, validTuple02.Item1);
                Assert.AreEqual(daysList[1].Item2, validTuple02.Item2);
            });
        }

        [Test]
        public void When_CallExecuteMethodWithSortedDescArray_ReturnNull()
        {
            //Arrange 
            var arr = new int[] { 50, 40, 30, 20, 10 };

            //Act
            var daysList = StockBuySell.Execute(arr);

            //Assert
            Assert.IsNull(daysList);
        }
    }

}
