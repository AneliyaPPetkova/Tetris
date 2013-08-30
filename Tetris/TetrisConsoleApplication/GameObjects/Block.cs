using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApplication
{
    public class Block : GameObject
    {
        // Fields
        public new const string ObjectType = "Block";

        // Constructors
        //public block(position position)
        //    : base(position, '\u2588', consolecolor.darkgray)
        //{
        //}

        // Methods
        public override string GetObjectType()
        {
            return Block.ObjectType;
        }
    }
}
