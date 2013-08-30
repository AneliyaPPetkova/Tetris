using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApplication
{
    public abstract class GameObject
    {
        public const string ObjectType = "Object";

        // Constructors
        protected GameObject(Position position, char symbol, ConsoleColor color)
        {
            this.Position = position;
            this.Symbol = symbol;
            this.Color = color;
        }

        // Properties
        public Position Position { get; protected set; }

        public char Symbol { get; protected set; }

        public ConsoleColor Color { get; protected set; }

        // Methods
        public virtual void UpdatePosition()
        {
        }

        public virtual string GetObjectType()
        {
            return GameObject.ObjectType;
        }
    }
}
