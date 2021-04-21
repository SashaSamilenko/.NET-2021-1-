using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZeroChrest
{
    public delegate void Menu();
    public delegate void OutPutGame(Game game);
    public class GameInterface
    {
        public event Menu MenuA;
        public event Menu MenuB;
        public event OutPutGame OutPutField;
        private Game game;
        public GameInterface()
        {
            game = new Game();
        }
        public void StartGame()
        {
            Saver gameHistory = new Saver();
            OutPutField?.Invoke(game);
            int x, y;
            MenuA?.Invoke();
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            if ((x < 1) || (x > 4) || (y < 1) || (y > 4))
            {
                game.RestoreState(gameHistory.GetLastMemento());
            }
            while (game.AddPoint(x, y) == false)
            {
                gameHistory.SetMemento(game.SaveMemento());
                Console.Clear();
                OutPutField?.Invoke(game);
                if (game.CheckAll())
                {
                    break;
                }
                if (game.currentPlayer == playerSymbol.playerA)
                {
                    MenuA?.Invoke();
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    MenuB?.Invoke();
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());
                }
                if ((x < 1) || (x > 3) || (y < 1) || (y > 3))
                {
                    game.RestoreState(gameHistory.GetLastMemento());
                    x = game.X[game.X.Count - 2];
                    y = game.Y[game.Y.Count - 2];
                }
            }
            if (game.currentPlayer == playerSymbol.playerA)
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
                OutPutField?.Invoke(game);
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
    }
}
