using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Core.Domain;
using MarsRover.Core.Enums;
using MarsRover.Services.Abstract;

namespace MarsRover.Services.Concrete
{
    public class RoverManager : ISpaceVehicle
    {
        #region members
        Grid _grid { get; set; }
        private int _positionX { get; set; }
        private int _positionY { get; set; }
        private DirectionEnum _directionEnum { get; set; }
        #endregion

        #region ctor
        public RoverManager(int x, int y, DirectionEnum directionEnum, Grid plateau)
        {
            _positionX = x;
            _positionY = y;
            _directionEnum = directionEnum;
            _grid = plateau;
        }
        #endregion

        #region methods
        public void Move()
        {
            switch (_directionEnum)
            {
                case DirectionEnum.N when _grid.Y > _positionY:
                    _positionY++;
                    break;
                case DirectionEnum.E when _grid.X > _positionX:
                    _positionX++;
                    break;
                case DirectionEnum.S when _positionY > 0:
                    _positionY--;
                    break;
                case DirectionEnum.W when _positionX > 0:
                    _positionX--;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public void SetDirection(char strRotate)
        {
            _directionEnum = strRotate switch
            {
                'L' => (_directionEnum - 90) < DirectionEnum.N ? DirectionEnum.W : _directionEnum - 90,
                'R' => (_directionEnum + 90) > DirectionEnum.W ? DirectionEnum.N : _directionEnum + 90,
                _ => _directionEnum
            };
        }
        public string Operation(string controlPosition)
        {
            foreach (var character in controlPosition)
            {
                if (character is 'L' or 'R')
                    SetDirection(character);
                else if (character == 'M')
                    Move();
            }

            return $"{_positionX} {_positionY} {_directionEnum}";
        }
        #endregion

    }
}
