using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Pieces
{
    internal abstract class Piece
    {
        public Location currentLocation;

        public abstract Location Move();

        public abstract List<Location> ValidMoves();
    }
}