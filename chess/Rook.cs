using Board;
namespace Chess
{
    public class Rook : Piece
    {

        public Rook(ChessBoard boad, Color color) : base(color, boad) { }

        private bool CanMove(Position pos)
        {
            Piece p = board.piece(pos);
            return p == null || p.color != this.color;
        }

        public override bool[,] PosibleMoves()
        {
            bool[,] mat = new bool[board.Rows, board.Columns];
            Position pos = new Position(0, 0);
            //acima
            pos.SetValues(pos.row - 1, pos.column);
            while (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row - 1;
            }
            //direita
            pos.SetValues(pos.row, pos.column + 1);
            while (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.column + 1;
            }
            //abaixo
            pos.SetValues(pos.row + 1, pos.column);
            while (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row + 1;
            }
            //esquerda
            pos.SetValues(pos.row, pos.column - 1);
            while (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
                if (board.piece(pos) != null && board.piece(pos).color != color)
                {
                    break;
                }
                pos.row = pos.row - 1;
            }
            return mat;
        }

        public override string ToString()
        {
            return "R";
        }

    }
}