namespace Boad
{
    public class Piece
    {

        public Position position { get; set; }
        public Color color { get; protected set; }
        public int QtdeMoves { get; protected set; }
        public ChessBoad boad { get; protected set; }

        public Piece(Color color, ChessBoad boad)
        {
            this.position = null;
            this.color = color;
            this.boad = boad;
            QtdeMoves = 0;
        }
    }
}