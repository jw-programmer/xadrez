using Board;

namespace Chess
{
    class ChessMatch
    {
        public ChessBoard Board { get; private set; }
        private int Turn;
        private Color TurnPlayer;
        public bool Finish { get; private set; }

        public ChessMatch()
        {
            Board = new ChessBoard(8, 8);
            Turn = 1;
            TurnPlayer = Color.White;
            Finish = false;
            PlacePieces();
        }

        public void ExecMove(Position origin, Position destiny)
        {
            Piece p = Board.DropPiece(origin);
            p.AddMovePiece();
            Piece CathPiece = Board.DropPiece(destiny);
            Board.PlacePiece(p, destiny);
        }

        public void PlacePieces()
        {
            Board.PlacePiece(new King(Board, Color.White), new ChessPosition('c', 1).ToPosition());

        }
    }
}