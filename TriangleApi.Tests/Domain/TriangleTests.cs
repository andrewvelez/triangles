using Xunit;
using System;

namespace TriangleApi.Domain
{
    public class TriangleTests
    {

        [Fact]
        public void Ctor_AnyNegativeParameter_ThrowsArgumentOutOfRangeException()
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
        public void Ctor_AnyZeroParameter_ThrowsArgumentOutOfRangeException()
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
        public void Ctor_AnyInfinityParameter_ThrowsArgumentOutOfRangeException()
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

        [Fact]
        public void GetSideLengthType_EquilateralParameters_ReturnsEquilateral()
        {
            var testTriangle = new Triangle(10.2, 10.2, 10.2);
            Assert.Equal(Triangle.SideLengthType.Equilateral, testTriangle.GetSideLengthType());
        }

        [Fact]
        public void GetSideLengthType_IsoscelesParameters_ReturnsIsosceles()
        {
            var testTriangle = new Triangle(10.2, 10.2, 15);
            Assert.Equal(Triangle.SideLengthType.Isosceles, testTriangle.GetSideLengthType());
        }

        [Fact]
        public void GetSideLengthType_ScaleneParameters_ReturnsScalene()
        {
            var testTriangle = new Triangle(10.2, 15, 2);
            Assert.Equal(Triangle.SideLengthType.Scalene, testTriangle.GetSideLengthType());
        }

    }
}
