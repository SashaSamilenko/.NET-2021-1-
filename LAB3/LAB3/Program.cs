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
            StartGame(game);
            Console.ReadKey();
        }
        static void StartGame(Game game)
        {
            Saver gameHistory = new Saver();
            OutPutField(game);
            int x, y;
            MenuA();
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if ((x<0)||(x>2)|| (y<0)||(y>3))
            {
                game.RestoreState(gameHistory.GetLastMemento());
            }
            while (game.AddPoint(x,y)==false)
            {
                gameHistory.SetMemento(game.SaveMemento());
                Console.Clear();
                OutPutField(game);
                if (game.CheckAll())
                {
                    break;
                }
                if(game.currentPlayer==playerSymbol.playerA)
                {
                    MenuA();
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    MenuB();
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                }
                if ((x < 0) || (x > 2) || (y < 0) || (y > 2))
                {
                    game.RestoreState(gameHistory.GetLastMemento());
                    x = game.X[game.X.Count - 2];
                    y = game.Y[game.Y.Count - 2];
                }
            }
            //game.AddPoint(x,y);
            if(game.currentPlayer==playerSymbol.playerA)
            {
                game.currentPlayer = playerSymbol.playerB;
            }
            else
            {
                game.currentPlayer = playerSymbol.playerA;
            }
            if (game.AddPoint(x, y) == true)
            {
                Console.Clear();
                OutPutField(game);
                if (game.currentPlayer == playerSymbol.playerA)
                {
                    Console.WriteLine("Player A won!");
                }
                else
                {
                    Console.WriteLine("Player B won!");
                }
            }
            else
            {
                Console.WriteLine("Game finished of draw!");
            }
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
