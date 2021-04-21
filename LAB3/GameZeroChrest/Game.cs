using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZeroChrest
{
    public enum playerSymbol
    {
        playerA,
        playerB
    }
    public class Game
    {
        internal Field gameField;
        public playerSymbol currentPlayer = playerSymbol.playerA;
        private Checker checker;
        public List<int> X;
        public List<int> Y;
        public Game()
        {
            checker = new Checker();
            gameField = new Field();
            X = new List<int>();
            Y = new List<int>();
        }
        public bool CheckAll()
        {
            return checker.CheckAll();
        }
        public bool AddPoint(int x, int y)
        {
            playerSymbol player = currentPlayer;
            if (x < 3 && y < 3)
            {
                if (gameField.field[x, y] == null)
                {
                    X.Add(x);
                    Y.Add(y);
                    if (currentPlayer==playerSymbol.playerA)
                    {
                        gameField.field[x, y] = "X";
                        currentPlayer = playerSymbol.playerB;
                    }
                    else 
                    {
                        gameField.field[x, y] = "0";
                        currentPlayer = playerSymbol.playerA;
                    }
                }
            }
            else
            {
                new ArgumentOutOfRangeException("You came out from available range of values!");
            }
            return checker.Check(gameField, player);
        }
        public string this[int x, int y]
        {
            get
            {
                if (x < 3 && y < 3)
                    return gameField.field[x, y];
                else
                {
                    new ArgumentOutOfRangeException("You came out from available range of values!");
                    return null;
                }
            }
        }
        public GameMemento SaveMemento()
        {
            return new GameMemento(this);
        }
        public void RestoreState(GameMemento memento)
        {
            this.gameField = memento.gameField;
            this.currentPlayer = memento.currentPlayer;
            this.X = memento.X;
            this.Y = memento.Y;
        }
    }
}
