using System;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] gameBoard = Tablero.Generate();
            while(true)
            {
                Tablero.printBoard(gameBoard);
                gameBoard = Tablero.next_Generation(gameBoard);
                Thread.Sleep(300);
            }
        }
    }
}
