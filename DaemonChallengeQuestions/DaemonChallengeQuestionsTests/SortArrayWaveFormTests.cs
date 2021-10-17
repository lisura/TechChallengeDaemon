using DaemonChallengeQuestions;
using NUnit.Framework;

namespace DaemonChallengeQuestionsTests
{
    public class SortArrayWaveFormTests
    {
        [Test]
        public void When_CallExecuteMethodWithArray_ReturnArrayInWaveForm()
        {
            //Arrange 
            var arr1 = new int[] { 10, 5, 6, 3, 2, 20, 100, 80 };
            var arr2 = new int[] { 20, 10, 8, 6, 4, 2 };
            var arr3 = new int[] { 2, 4, 6, 8, 10, 20 };
            var arr4 = new int[] { 3, 6, 5, 10, 7, 20 };


            //Act
            var arrWaveTest01 = SortArrayWaveForm.Execute(arr1);
            var arrWaveTest02 = SortArrayWaveForm.Execute(arr2);
            var arrWaveTest03 = SortArrayWaveForm.Execute(arr3);
            var arrWaveTest04 = SortArrayWaveForm.Execute(arr4);

            //Assert
            Assert.Multiple(() =>
            {
                Assert.IsTrue(CheckIfIsWave(arrWaveTest01));
                Assert.IsTrue(CheckIfIsWave(arrWaveTest02));
                Assert.IsTrue(CheckIfIsWave(arrWaveTest03));
                Assert.IsTrue(CheckIfIsWave(arrWaveTest04));
            });

        }

        private bool CheckIfIsWave(int[] arr)
        {
            for (int i = 1; i < arr.Length; i = i + 2)
            {
                if (i + 1 > arr.Length - 1)
                {
                    if (arr[i - 1] < arr[i])
                    {
                        return false;
                    }
                }
                else
                {
                    if (arr[i - 1] < arr[i] || arr[i] > arr[i + 1])
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }
}
