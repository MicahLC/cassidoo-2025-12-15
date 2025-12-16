using FluentAssertions;

namespace cassidoo_2025_12_15
{
    [TestClass]
    public sealed class LatinSquareTests
    {
        [TestMethod]
        public void Input1()
        {
            int[][] latinSquare = LatinSquare.GenerateLatinSquare(1);
            latinSquare[0][0].Should().Equals(1);
            latinSquare.Should().HaveCount(1);
            latinSquare[0].Should().HaveCount(1);
        }

        [TestMethod]
        public void Input3()
        {
			int[][] latinSquare = LatinSquare.GenerateLatinSquare(3);
            latinSquare.Should().Equal([[1, 2, 3], [2, 3, 1], [3, 1, 2]]);
		}
    }
}
