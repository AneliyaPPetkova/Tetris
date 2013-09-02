using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisConsoleApplication
{
    class Tetris
    {
        //static Engine GetEngineInstance()
        //{
        //    return new Engine();
        //}
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            //Engine engine = GetEngineInstance();
            char C = Encoding.GetEncoding(437).GetChars(new byte[] { 219 })[0];
            for (int i = 0; i < 3; i++)
            {
                Console.Write(C);
                Console.Write(C);
                if (i == 0)
                {
                    Console.Write(C);
                    Console.Write(C);
                }
                //Console.Beep(100, 100);
                Console.WriteLine();
            }

            Console.WriteLine((char)219);
        }
    }
}