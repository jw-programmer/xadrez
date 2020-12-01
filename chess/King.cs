using Board;
namespace Chess
{
    public class King : Piece
    {

        public King(ChessBoard boad, Color color) : base(color, boad) { }

        public override string ToString()
        {
            return "K";
        }

    }
}