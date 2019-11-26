namespace Chess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Chess.Pieces;

    internal class ChessBoard
    {
        private Spot[,] board;

        public ChessBoard()
        {
            this.board = new Spot[8, 8];
        }

        public void ResetBoardToOriginalPostions()
        {

        }

        public void ResetBoardToBeBlank()
        {

        }
    }
}