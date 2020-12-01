using Boad;
namespace Chess
{
    public class Rook : Piece
    {

        public Rook(ChessBoad boad, Color color) : base(color, boad) { }

        public override string ToString()
        {
            return "R";
        }

    }
}