using MarsRover.Core.Enums;
using MarsRover.Services.Concrete;
using System;
using MarsRover.Core.Domain;
using Xunit;

namespace MarsRover.Test
{
    public class UnitTest
    {
       
        [Fact]
        public void TestMethod1()
        {
            // Test input MMRMMRMRRM
            var roverManager = new RoverManager(3, 3, DirectionEnum.E, new Grid(5, 5));
            Assert.Equal("5 1 E", roverManager.Operation("MMRMMRMRRM"));
        }
        [Fact]
        public void TestMethod2()
        {
            // Test inputs LMLMLMLMM
            var roverManager = new RoverManager(1, 2, DirectionEnum.N, new Grid(5, 5));
            Assert.Equal("1 3 N", roverManager.Operation("LMLMLMLMM"));
        }

        [Fact]
        public void TestMethod3()
        {
            // Test inputs LMLMLMRRM
            var roverManager = new RoverManager(1, 2, DirectionEnum.N, new Grid(3, 3));
            Assert.Equal("X X X", roverManager.Operation("LMLMLMRRM"));
        }

        [Fact]
        public void TestMethod4()
        {
            // Test inputs LRLRLRLRLRLR
            var roverManager = new RoverManager(1, 2, DirectionEnum.N, new Grid(4, 4));
            Assert.Equal("1 2 N", roverManager.Operation("LRLRLRLRLRLR"));
        }


        [Fact]
        public void TestMethod5()
        {
            // Test inputs LRLRLRLRLRLR
            var roverManager = new RoverManager(1, 2, DirectionEnum.N, new Grid(6, 6));
            Assert.Equal("1 2 N", roverManager.Operation("LLLLLLLLL"));
        }
    }
}
