namespace Boad
{
    public class ChessBoad
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public ChessBoad(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
            Pieces = new Piece[rows, columns];
        }

        public Piece piece(int row, int column)
        {
            return Pieces[row, column];
        }

        public void PlacePiece(Piece piece, Position pos){
            Pieces[pos.row, pos.column] = piece;
            piece.position = pos;
        }
    }
}