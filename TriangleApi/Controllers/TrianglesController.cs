using System;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;

namespace TriangleApi.Controllers
{
    public class TrianglesController : ApiController
    {

        public Models.Triangle GetTriangle(int side1, int side2, int side3)
        {
            return new Models.Triangle(new Domain.Triangle(side1, side2, side3));
        }

    }
}