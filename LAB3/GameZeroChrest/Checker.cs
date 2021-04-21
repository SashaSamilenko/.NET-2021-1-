using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZeroChrest
{
    internal class Checker
    {
        private Field gameField;
        private string symbol = null;
        internal bool Check(Field gameField, playerSymbol currentPlayer)
        {
            this.gameField = gameField;
            if(currentPlayer==playerSymbol.playerA)
            {
                symbol = "X";
                if (CheckColumns() == true) return true;
                if (CheckRows() == true) return true;
                if (CheckMainDiagonal() == true) return true;
                if (CheckSecondDiagonal() == true) return true;
                return false;
            }
            else
            {
                symbol = "0";
                if (CheckColumns() == true) return true;
                if (CheckRows() == true) return true;
                if (CheckMainDiagonal() == true) return true;
                if (CheckSecondDiagonal() == true) return true;
                return false;
            }
        }
        private bool CheckColumns()
        {
            Int32 count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameField.field[j, i] == symbol)
                    {
                        count++;
                    }
                }
                if (count == 3) return true;
                count = 0;
            }
            return false;
        }
        private bool CheckRows()
        {
            Int32 count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (gameField.field[i, j] == symbol)
                    {
                        count++;
                    }
                }
                if (count == 3) return true;
                count = 0;
            }
            return false;
        }
        private bool CheckMainDiagonal()
        {
            Int32 count = 0;
            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                if (gameField.field[i, j] == symbol)
                {
                    count++;
                }
                j++;
            }
            return count==3?true:false;
        }
        private bool CheckSecondDiagonal()
        {
            Int32 count = 0;
            int j = 2;
            for (int i = 0; i < 3; i++)
            {
                if (gameField.field[i, j] == symbol)
                {
                    count++;
                }
                j--;
            }
            return count == 3 ? true : false;
        }
        internal bool CheckAll()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(gameField.field[i,j]==null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
