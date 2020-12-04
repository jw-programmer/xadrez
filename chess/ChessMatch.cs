using Board;

namespace Chess
{
    class ChessMatch
    {
        public ChessBoard Board { get; private set; }
        public int Turn {get; private set;}
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
            PassTurn();
        }

        public void OriginPosIsValid(Position pos)
        {
            if(Board.piece(pos) == null)
            {
                throw new BoardException("Não existe peça a ser movida");
            }
            if(TurnPlayer != Board.piece(pos).color)
            {
                throw new BoardException("Você não pode mover essa peça nessa vez");
            }
            if(!Board.piece(pos).HavePossibleMoves())
            {
                throw new BoardException("Não exite um lugar possível para esta peça");
            }
        }

        private void PassTurn()
        {
            if(TurnPlayer == Color.White)
            {
                TurnPlayer = Color.Black;
            }else
            {
                TurnPlayer = Color.White;
            }
        }

        public void PlacePieces()
        {
            Board.PlacePiece(new King(Board, Color.White), new ChessPosition('c', 1).ToPosition());
            Board.PlacePiece(new Rook(Board, Color.White), new ChessPosition('c', 2).ToPosition());

        }
    }
}