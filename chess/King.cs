using Boad;
namespace Chess
{
    public class King : Piece
    {

        public King(ChessBoad boad, Color color) : base(color, boad) { }

        public override string ToString()
        {
            return "K";
        }

    }
}