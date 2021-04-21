using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameZeroChrest;

namespace LAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            GameInterface gameInterface = new GameInterface();
            gameInterface.MenuA += MenuA;
            gameInterface.MenuB += MenuB;
            gameInterface.OutPutField += OutPutField;
            gameInterface.StartGame();
            Console.ReadKey();
        }
        static void MenuA()
        {
            Console.WriteLine("Player A, input coordinates for X-value or input 'go back': ");
        }
        static void MenuB()
        {
            Console.WriteLine("Player B, input coordinates for Zero-value or input 'go back': ");
        }
        static void OutPutField(Game game)
        {
            Console.WriteLine("---------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(game[i, 0] + " | " + game[i, 1] + " | " + game[i, 2] + "\n---------");
            }
        }
    }
}
