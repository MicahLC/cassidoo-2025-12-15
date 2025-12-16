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
			latinSquare.Should().HaveCount(1);
			latinSquare[0].Should().HaveCount(1);
			latinSquare[0][0].Should().Be(1);
        }

        [TestMethod]
        public void Input3()
        {
			int[][] latinSquare = LatinSquare.GenerateLatinSquare(3);
			latinSquare.Should().HaveCount(3);
            latinSquare[0].Should().Equal([1, 2, 3]);
			latinSquare[1].Should().Equal([2, 3, 1]);
			latinSquare[2].Should().Equal([3, 1, 2]);
			// latinSquare[0].Should().Equal([[1, 2, 3], [2, 3, 1], [3, 1, 2]]);
		}
    }
}
