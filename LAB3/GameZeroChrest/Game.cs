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
        internal playerSymbol currentPlayer = playerSymbol.playerA;
        private Checker checker;
        internal List<int> X;
        internal List<int> Y;
        public Game()
        {
            checker = new Checker();
            gameField = new Field();
            X = new List<int>();
            Y = new List<int>();
        }
        internal bool CheckAll()
        {
            return checker.CheckAll();
        }
        internal bool AddPoint(int x, int y)
        {
            playerSymbol player = currentPlayer;
            if (x>0 && x < 4 && y < 4 && y>0)
            {
                if (gameField.field[x-1, y-1] == null)
                {
                    if(X.Count>0)
                    {
                        if(X[X.Count-1]!=x && X[Y.Count-1]!=y)
                        {
                            X.Add(x);
                            Y.Add(y);
                        }
                    }
                    else 
                    {
                        X.Add(x);
                        Y.Add(y);
                    }
                    if (currentPlayer==playerSymbol.playerA)
                    {
                        gameField.field[x-1, y-1] = "X";
                        currentPlayer = playerSymbol.playerB;
                    }
                    else 
                    {
                        gameField.field[x-1, y-1] = "0";
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
                if (x>=0 && x < 3 && y < 3 && y >= 0)
                    return gameField.field[x, y];
                else
                {
                    new ArgumentOutOfRangeException("You came out from available range of values!");
                    return null;
                }
            }
        }
        internal GameMemento SaveMemento()
        {
            return new GameMemento(this);
        }
        internal void RestoreState(GameMemento memento)
        {
            this.gameField = memento.gameField;
            this.currentPlayer = memento.currentPlayer;
            for(int i=0;i<this.X.Count;i++)
            {
                if (i < memento.X.Count)
                {
                    this.X[i] = memento.X[i];
                    this.Y[i] = memento.Y[i];
                }
                else 
                {
                    this.X.RemoveAt(i);
                    this.Y.RemoveAt(i);
                }
            }
            if(memento.Y.Count==0)
            {
                this.X.Clear();
                this.Y.Clear();
            }
        }
    }
}
