using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_TicTacToe.Model
{
    public class Board
    {
        private int size;
        private PlayingPiece[,] board;

        public Board(int size)
        {
            this.size = size;
            board = new PlayingPiece[size, size];
        }

        public bool IsValidMove(int row, int col)
        {
            // Check if the move is within the board and not already occupied
            return row >= 0 && row < size && col >= 0 && col < size && board[row, col] == null;
        }

        public void PlacePiece(int row, int col, PlayingPiece piece)
        {
            board[row, col] = piece;
        }

        // Print Board
        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(board[i, j] == null ? " " : board[i, j].GetPieceType());
                    if (j < size - 1)
                    {
                        Console.Write(" | ");
                    }
                }
                Console.WriteLine();
                if (i < size - 1)
                {
                    Console.WriteLine(new string('-', size * 4 - 1));
                }
            }
        }

        public bool HasWon(PlayingPiece playingPiece)
        {
            // Check if this playing piece has won in rows, columns, or diagonals
            for (int i = 0; i < size; i++)
            {
                bool rowWin = true;
                bool colWin = true;
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j] != playingPiece)
                    {
                        rowWin = false;
                    }
                    if (board[j, i] != playingPiece)
                    {
                        colWin = false;
                    }
                }
                if (rowWin || colWin)
                {
                    return true;
                }
            }

            bool diag1Win = true;
            bool diag2Win = true;

            for (int i = 0; i < size; i++)
            {
                if (board[i, i] != playingPiece)
                {
                    diag1Win = false;
                }
                if (board[i, size - 1 - i] != playingPiece)
                {
                    diag2Win = false;
                }
            }

            return diag1Win || diag2Win;
        }

        public bool IsFull()
        {
            // Check if the board is full
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j] == null)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
