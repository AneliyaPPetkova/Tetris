using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApplication
{
    public class Block : GameObject, ICollapsable
    {
        // Fields
        public new const string ObjectType = "Block";
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