using Board;
namespace Chess
{
    public class Rook : Piece
    {

        public Rook(ChessBoard boad, Color color) : base(color, boad) { }

        public override string ToString()
        {
            return "R";
        }

    }
}