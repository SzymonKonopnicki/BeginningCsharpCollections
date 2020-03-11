using System;
using System.Collections.Generic;
using System.Text;

namespace _8_Game
{
    public class TicTacToe
    {
        private Square[][] board =
        {
            new Square[3],
            new Square[3],
            new Square[3]
        };

        public void PlayGame()
        {
            Player player = Player.Crosses;

            bool flaga = true;
            while (flaga)
            {
                DisplayBoard();
                flaga = PlayMove(player);
                if (!flaga)
                {
                    return;
                }

                player = 3 - player;
            }
        }

        private void DisplayBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(" " + board[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}
