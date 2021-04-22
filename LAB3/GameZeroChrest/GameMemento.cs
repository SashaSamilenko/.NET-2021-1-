using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZeroChrest
{
    internal class GameMemento
    {
        internal Field gameField;
        internal playerSymbol currentPlayer;
        internal List<int> X;
        internal List<int> Y;
        internal GameMemento(Game game)
        {
            gameField = new Field();
            gameField.field = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    gameField.field[i, j] = game.gameField.field[i, j];
                }
            }
            currentPlayer = game.currentPlayer;
            X = new List<int>();
            Y = new List<int>();
            for (int i = 0; i < game.X.Count; i++)
            {
                this.X.Add(game.X[i]);
                this.Y.Add(game.Y[i]);
            }
        }
    }
}
