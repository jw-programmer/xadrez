namespace Board
{
    public class Piece
    {

        public Position position { get; set; }
        public Color color { get; protected set; }
        public int QtdeMoves { get; protected set; }
        public ChessBoard boad { get; protected set; }

        public Piece(Color color, ChessBoard boad)
        {
            this.position = null;
            this.color = color;
            this.boad = boad;
            QtdeMoves = 0;
        }
    }
}