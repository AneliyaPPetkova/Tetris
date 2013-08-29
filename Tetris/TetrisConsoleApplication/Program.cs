using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApplication
{
    class Program
    {
        static Engine GetEngineInstance()
        {
            return new Engine();
        }

        static void Main(string[] args)
        {
            Engine engine = GetEngineInstance();
        }
    }
}
