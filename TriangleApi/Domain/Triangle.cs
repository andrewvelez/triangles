using System;

namespace TriangleApi.Domain
{
    public class Triangle
    {

        public enum SideLengthType
        {
            Scalene,
            Isosceles,
            Equilateral
        }

        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }

        public Triangle(double thisSide1, double thisSide2, double thisSide3)
        {
            Side1 = GetVerifiedSideLength(thisSide1);
            Side2 = GetVerifiedSideLength(thisSide2);
            Side3 = GetVerifiedSideLength(thisSide3);
        }

        public bool IsEquilateral()
        {
            return false;
        }

        public bool IsIsosceles()
        {
            return false;
        }

        public bool IsScalene()
        {
            return false;
        }

        private SideLengthType GetSideLengthType()
        {
            return SideLengthType.Scalene;
        }

        private double GetVerifiedSideLength(double side)
        {
            if (double.IsInfinity(side) || side <= 0.0)
            {
                throw new ArgumentOutOfRangeException("For a valid simple triangle, sides should be real positive numbers");
            }
            else
            {
                return side;
            }
        }

    }
}