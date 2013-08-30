using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApplication
{
    public class PieceI : IMovable
    {
        //Fields
        public const string ObjectType = "PieceI";
        private Position position;
        private OrientationType orientation;
        public const ConsoleColor Color = ConsoleColor.Blue;
        private List<Position> blockPositions = new List<Position>(4);

        //Constructors
        public PieceI(Position startPosition, OrientationType orientation)
        {
            this.position = startPosition;
            this.orientation = orientation;
        }


        //Properties
        public OrientationType Orientation
        {
            get
            {
                return this.orientation;
            }
            set
            {
                this.orientation = value;
            }
        }

        public Position Position
        {
            get
            {
                return this.position;
            }
            set
            {
                this.position = value;
            }
        }


        public List<Position> BlockPositions
        {
            get
            {
                return this.blockPositions;
            }
            set
            {
                this.blockPositions = new List<Position>(4);
            }
        }

        //Methods
        public void Drop(List<Position> blockPositions, OrientationType orientation)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void MoveLeft(List<Position> blockPositions, OrientationType orientation)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void MoveRight(List<Position> blockPositions, OrientationType orientation)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void RotateClockwise(List<Position> blockPositions, OrientationType orientation)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }

        public void RotateCounterClockwise(List<Position> blockPositions, OrientationType orientation)
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
