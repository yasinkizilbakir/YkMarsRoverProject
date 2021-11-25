using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Services.Abstract
{
    public interface ISpaceVehicle

    {
        void Move();
        void SetDirection(char strRotate);
        string Operation(string strControl);
    }
}
