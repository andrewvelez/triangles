using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TriangleApi.Models
{
    public class Triangle
    {

        public double Side1 { get; set; }

        public double Side2 { get; set; }

        public double Side3 { get; set; }

        public string TriangleType { get; set; }

        public Triangle(Domain.Triangle thisTriangle)
        {
            Side1 = thisTriangle.Side1;
            Side2 = thisTriangle.Side2;
            Side3 = thisTriangle.Side3;
            TriangleType = thisTriangle.GetSideLengthType().ToString();
        }

    }
}