namespace Board
{
    public class ChessBoard
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public ChessBoard(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];
        }

        public Piece piece(int row, int column)
        {
            return Pieces[row, column];
        }

        public Piece piece(Position position)
        {
            return Pieces[position.row, position.column];
        }

        public void PlacePiece(Piece piece, Position pos)
        {
            if(HavePiece(pos))
            {
                throw new BoardException("Já existe peça nessa posição");
            }
            Pieces[pos.row, pos.column] = piece;
            piece.position = pos;
        }

        public Piece DropPiece(Position pos){
            if(piece(pos) == null)
            {
                return null;
            }
            Piece aux = piece(pos);
            aux.position = null;
            Pieces[pos.row, pos.column] = null;
            return aux;
        }

        public bool HavePiece(Position pos)
        {
            ValidPosition(pos);
            return piece(pos) != null;
        }

        public bool PositionIsValid(Position pos)
        {
            if (pos.row < 0 || pos.row >= Rows || pos.column < 0 || pos.column >= Columns)
            {
                return false;
            }
            return true;
        }

        public void ValidPosition(Position pos)
        {
            if(!PositionIsValid(pos))
            {
                throw new BoardException("Posição inválida");
            }
        }
    }
}