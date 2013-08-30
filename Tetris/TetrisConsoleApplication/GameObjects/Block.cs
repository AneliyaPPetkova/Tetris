using System;
using System.Text;

namespace TetrisConsoleApplication
{
    public class Block : GameObject
    {
        // Fields
        public new const string ObjectType = "Block";
        private static char symbol = Encoding.GetEncoding(437).GetChars(new byte[] { 219 })[0];

        // Constructors
        public Block(Position position, ConsoleColor color)
            : base(position, symbol, color)
        {
        }

        // Methods
        public override string GetObjectType()
        {
            return Block.ObjectType;
        }
    }
}
