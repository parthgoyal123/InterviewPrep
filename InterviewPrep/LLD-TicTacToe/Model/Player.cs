using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_TicTacToe.Model
{
    public class Player
    {
        private string name;
        private PlayingPiece piece;

        public Player(string name, PlayingPiece piece)
        {
            this.name = name;
            this.piece = piece;
        }

        public string GetName()
        {
            return name;
        }

        public PlayingPiece GetPiece()
        {
            return piece;
        }

        // Set Name and Get Piece
        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPiece(PlayingPiece piece)
        {
            this.piece = piece;
        }
    }
}
