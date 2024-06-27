using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LLD_TicTacToe.Model;

namespace LLD_TicTacToe
{
    public class TicTacToeGame
    {
        private Board board;
        private Player[] players;
        private int currentPlayerIndex;

        public TicTacToeGame(Player player1, Player player2)
        {
            board = new Board(size: 3);
            players = new Player[2];
            players[0] = player1;
            players[1] = player2;
            currentPlayerIndex = 0;
        }

        public void Play()
        {
            while (true)
            {
                Player currentPlayer = players[currentPlayerIndex];
                
                Console.WriteLine(currentPlayer.GetName() + "'s turn");
                Console.WriteLine("Enter row and column numbers (0-2) separated by space:");
                string[] input = Console.ReadLine().Split(' ');
                int row = int.Parse(input[0]);
                int col = int.Parse(input[1]);

                if (board.IsValidMove(row, col))
                {
                    board.PlacePiece(row, col, currentPlayer.GetPiece());
                    board.Print();
                    if (board.HasWon(currentPlayer.GetPiece()))
                    {
                        Console.WriteLine(currentPlayer.GetName() + " wins!");
                        break;
                    }
                    else if (board.IsFull())
                    {
                        Console.WriteLine("It's a draw!");
                        break;
                    }
                    currentPlayerIndex = 1 - currentPlayerIndex;
                }
                else
                {
                    Console.WriteLine("Invalid move! Try again.");
                }
            }
        }
    }
}
