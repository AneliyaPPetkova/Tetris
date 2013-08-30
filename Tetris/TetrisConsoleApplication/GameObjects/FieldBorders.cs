using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApplication
{
    public class FieldBorders : GameObject
    {
        // Fields
        public new const string ObjectType = "FieldBorder";
        public const char symbol = '\u2588';

        // Constructors
        public FieldBorders(Position position)
            : base(position, symbol, ConsoleColor.DarkGreen)
        {
        }

        // Methods
        public override string GetObjectType()
        {
            return Block.ObjectType;
        }
    }
}
