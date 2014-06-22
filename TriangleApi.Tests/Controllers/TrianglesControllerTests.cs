using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using TriangleApi.Models;
using Xunit;

namespace TriangleApi.Controllers
{
    public class TrianglesControllerTests
    {

        [Fact]
        public void GetTriangle_ValidTriangle_TriangleModel()
        {
            var controller = new TrianglesController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            Triangle testTriangle = controller.GetTriangle(10, 20, 30);

            Assert.Equal(10, testTriangle.Side1);
            Assert.Equal(20, testTriangle.Side2);
            Assert.Equal(30, testTriangle.Side3);
        }

    }
}