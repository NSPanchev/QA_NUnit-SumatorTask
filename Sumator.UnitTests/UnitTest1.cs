using System.ComponentModel.DataAnnotations;

namespace Sumator.UnitTests
{
    public class SumatorTests
    {
        [Test]
        public void Test_Sumator_SumOfTwoPositiveNumbers()
        {
            var nums = new[] { 1, 2, };
            var actual = Sumator.Sum(nums);
            var expected = 3;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Sumator_SumOfTwoNegativeNumbers()
        {
            var nums = new[] { -1, - 2, };
            var actual = Sumator.Sum(nums);
            var expected = - 3;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Sumator_SumOfOneNumber()
        {
            var nums = new[] { 6 };
            var actual = Sumator.Sum(nums);
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }

    }
}