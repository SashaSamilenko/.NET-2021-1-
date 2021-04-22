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
            CurrentGame currentGame = new CurrentGame(game);
            currentGame.OutPutField += OutPutField;

            //Player A wins
            /*currentGame.startGame(1, 1, playerSymbol.playerA);
            currentGame.continueGame(2, 2, playerSymbol.playerB);
            currentGame.continueGame(2, 1, playerSymbol.playerA);
            currentGame.continueGame(1, 2, playerSymbol.playerB);
            currentGame.continueGame(3, 1, playerSymbol.playerA);*/

            //Player B wins
            /*currentGame.startGame(1, 1, playerSymbol.playerA);
            currentGame.continueGame(2, 2, playerSymbol.playerB);
            currentGame.continueGame(3, 3, playerSymbol.playerA);
            currentGame.continueGame(1, 3, playerSymbol.playerB);
            currentGame.continueGame(1, 2, playerSymbol.playerA);
            currentGame.continueGame(3, 1, playerSymbol.playerB);*/

            //A draw!
            currentGame.startGame(1, 1, playerSymbol.playerA);
            currentGame.continueGame(2, 2, playerSymbol.playerB);
            currentGame.continueGame(3, 3, playerSymbol.playerA);
            currentGame.continueGame(2, 3, playerSymbol.playerB);
            currentGame.continueGame(1, 3, playerSymbol.playerA);
            currentGame.continueGame(3, 1, playerSymbol.playerB);
            currentGame.continueGame(2, 1, playerSymbol.playerA);
            currentGame.continueGame(1, 2, playerSymbol.playerB);
            currentGame.continueGame(3, 2, playerSymbol.playerA);

            //The game with two returnings
            /*currentGame.startGame(1, 1, playerSymbol.playerA);
            currentGame.continueGame(2, 2, playerSymbol.playerB);
            currentGame.GoBack();
            currentGame.GoBack();*/

            //The game with three returnings
            /*currentGame.startGame(1, 1, playerSymbol.playerA);
            currentGame.continueGame(2, 2, playerSymbol.playerB);
            currentGame.continueGame(3, 3, playerSymbol.playerA);
            currentGame.GoBack();
            currentGame.GoBack();
            currentGame.GoBack();*/

            //The game with returning in the starting
            /*currentGame.startGame(1, 1, playerSymbol.playerA);
            currentGame.GoBack();*/

            Console.WriteLine("Thank you for using this game!");
            Console.ReadKey();
        }
        static void OutPutField(Game game)
        {
            Console.WriteLine("Current field:\n---------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(game[i, 0] + " | " + game[i, 1] + " | " + game[i, 2] + "\n---------");
            }
        }
    }
}
