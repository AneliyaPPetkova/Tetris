using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApplication
{
    interface IMovable
    {
        void Drop(List<Position> blockPositions, OrientationType orientation);
        void MoveLeft(List<Position> blockPositions, OrientationType orientation);
        void MoveRight(List<Position> blockPositions, OrientationType orientation);
        void RotateClockwise(List<Position> blockPositions, OrientationType orientation);
        void RotateCounterClockwise(List<Position> blockPositions, OrientationType orientation);
    }
}
