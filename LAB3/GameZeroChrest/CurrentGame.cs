using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZeroChrest
{
    public delegate void OutPutGame(Game game);
    public class CurrentGame
    {
        public event OutPutGame OutPutField;
        private Game game;
        private Saver gameHistory;
        private int x;
        private int y;
        public CurrentGame(Game game)
        {
            this.game = game;
            gameHistory = new Saver();
            gameHistory.SetMemento(game.SaveMemento());
        }
        public void startGame(int x, int y,playerSymbol player)
        {
            if (game.currentPlayer == player)
            {
                OutPutField?.Invoke(game);
                if ((x < 1) || (x > 4) || (y < 1) || (y > 4))
                {
                    game.RestoreState(gameHistory.GetLastMemento());
                }
                else
                {
                    game.AddPoint(x, y);
                    gameHistory.SetMemento(game.SaveMemento());
                    OutPutField?.Invoke(game);
                }
            }
            else
            {
                throw new Exception("Choose another player for this course!");
            }
        }
        public void continueGame(int x, int y, playerSymbol player)
        {
            if (game.currentPlayer == player)
            {
                if ((x > 1) || (x < 4) || (y > 1) || (y < 4))
                {
                    if (game.AddPoint(x, y) == false)
                    {
                        gameHistory.SetMemento(game.SaveMemento());
                        OutPutField?.Invoke(game);
                        if (game.CheckAll() == true)
                        {
                            Winning();
                            return;
                        }
                    }
                    else
                    {
                        Winning();
                    }
                }
            }
            else
            {
                throw new Exception("Choose another player for this course!");
            }
        }
        private void Winning()
        {
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
        public void GoBack()
        {
            game.RestoreState(gameHistory.GetLastMemento());
            OutPutField?.Invoke(game);
            if (game.X.Count > 0)
            {
                x = game.X[game.X.Count - 1];
                y = game.Y[game.Y.Count - 1];
            }
        }
    }
}
