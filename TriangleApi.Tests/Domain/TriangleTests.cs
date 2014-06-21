using Xunit;
using System;

namespace TriangleApi.Domain
{
    public class TriangleTests
    {

        [Fact]
        public void Ctor_NegativeParameter_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    var badTriangle = new Triangle(-1, 2, 3);
                });

            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    var badTriangle = new Triangle(1, -2, 3);
                });

            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    var badTriangle = new Triangle(1, 2, -3);
                });
        }

        [Fact]
        public void Ctor_ZeroParameter_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    var badTriangle = new Triangle(0, 2, 3);
                });

            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    var badTriangle = new Triangle(1, 0, 3);
                });

            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    var badTriangle = new Triangle(1, 2, 0);
                });
        }

        [Fact]
        public void Ctor_InfinityParameter_ThrowsArgumentOutOfRangeException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    var badTriangle = new Triangle(Double.PositiveInfinity, 2, 3);
                });

            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    var badTriangle = new Triangle(1, Double.PositiveInfinity, 3);
                });

            Assert.Throws<ArgumentOutOfRangeException>(
                delegate
                {
                    var badTriangle = new Triangle(1, 2, Double.PositiveInfinity);
                });
        }

    }
}
