using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core.Infrastructure;

namespace MarsRover.Core.Domain
{
    public class Grid : IPlateau
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Grid(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }


    }
}
