namespace Chess.Pieces
{
    using System.Collections.Generic;

    internal abstract class Piece
    {
        public Location currentLocation;

        public abstract Location Move();

        public abstract List<Location> ValidMoves();
    }
}