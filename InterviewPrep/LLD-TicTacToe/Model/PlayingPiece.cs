using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD_TicTacToe.Model
{
    public abstract class PlayingPiece
    {
        private PieceType type;

        public PlayingPiece(PieceType type)
        {
            this.type = type;
        }

        public string GetPieceType()
        {
            return type.ToString();
        }
    }
}
