namespace Board
{
    public abstract class Piece
    {

        public Position position { get; set; }
        public Color color { get; protected set; }
        public int QtdeMoves { get; protected set; }
        public ChessBoard board { get; protected set; }

        public Piece(Color color, ChessBoard boad)
        {
            this.position = null;
            this.color = color;
            this.board = boad;
            QtdeMoves = 0;
        }

        public void AddMovePiece()
        {
            QtdeMoves++;
        }

        public bool HavePossibleMoves()
        {
            bool[,] mat = PosibleMoves();
            for (int i = 0; i < board.Columns; i++)
            {
                for (int j = 0; j < board.Rows; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public abstract bool[,] PosibleMoves();
    }
}