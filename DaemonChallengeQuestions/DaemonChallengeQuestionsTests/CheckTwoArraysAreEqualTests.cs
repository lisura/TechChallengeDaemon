using DaemonChallengeQuestions;
using NUnit.Framework;

namespace DaemonChallengeQuestionsTests
{
    public class CheckTwoArraysAreEqualTests
    {
        [Test]
        public void When_CallExecuteMethodWithEqualsArrays_ReturnYes()
        {
            //Arrange 
            var arr1 = new int[] { 1, 2, 5, 4, 0};
            var arr2 = new int[] { 2, 4, 5, 0, 1 };

            var arr3 = new int[] { 1, 2, 5, 4, 0, 2, 1 };
            var arr4 = new int[] { 2, 4, 5, 0, 1, 1, 2 };

            //Act
            var isEqualsTest01 = CheckTwoArraysAreEqual.Execute(arr1, arr2);
            var isEqualsTest02 = CheckTwoArraysAreEqual.Execute(arr3, arr4);

            //Assert
            Assert.AreEqual("Yes", isEqualsTest01);
            Assert.AreEqual("Yes", isEqualsTest02);
        }

        [Test]
        public void When_CallExecuteMethodWithDiferentArrays_ReturnNo()
        {
            //Arrange 
            var arr1 = new int[] { 1, 7, 1 };
            var arr2 = new int[] { 7, 7, 1 };

            //Act
            var isEquals = CheckTwoArraysAreEqual.Execute(arr1, arr2);

            //Assert
            Assert.AreEqual("No", isEquals);
        }
    }
}

