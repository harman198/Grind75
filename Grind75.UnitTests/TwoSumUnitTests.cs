using Grind75.Core;

namespace Grind75.UnitTests
{
    public class TwoSumUnitTests
    {
        [Theory]
        [MemberData(nameof(GetTestData))]
        public void SimpleSolutionTests((int idx1, int idx2)? expectedResult, int target, params int[] items)
        {
            var sut = new TwoSum();
            var actualResult = sut.SimpleSolution(items, target);

            Assert.Equal(expectedResult, actualResult);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { null, 0, null };
            yield return new object[] { null, 0, 0 };
            yield return new object[] { null, int.MaxValue, null };
            yield return new object[] { null, int.MinValue, null };
            yield return new object[] { (0, 1), 3, 1, 2 };
            yield return new object[] { (1, 2), 6, 3, 2, 4 };
            yield return new object[] { (0, 1), 9, 2, 7, 11, 15 };
            yield return new object[] { (0, 1), 6, 3, 3 };
        }
    }
}