using System;
using System.Text;

namespace TetrisConsoleApplication
{
    public class Block : GameObject, ICollapsable
    {
        // Fields
        public new const string ObjectType = "Block";
        private static char symbol = Encoding.GetEncoding(437).GetChars(new byte[] { 219 })[0];

        // Constructors
        public Block(Position position, ConsoleColor color)
            : base(position, symbol, color)
        {
        }
        private char Symbol = Convert.ToChar("219");

        // Constructors
        public Block(Position position) : base(position, '\u2588', ConsoleColor.DarkGray)
        {
        }

        // Methods
        public override string GetObjectType()
        {
            return Block.ObjectType;
        }

        public void Collapse()
        {
            // TODO: Implement this method
            throw new NotImplementedException();
        }
    }
}
