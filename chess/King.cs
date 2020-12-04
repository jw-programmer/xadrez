using Board;
namespace Chess
{
    public class King : Piece
    {

        public King(ChessBoard board, Color color) : base(color, board) { }

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
            if (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //ne
            pos.SetValues(pos.row - 1, pos.column + 1);
            if (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //direita
            pos.SetValues(pos.row, pos.column + 1);
            if (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //se
            pos.SetValues(pos.row + 1, pos.column + 1);
            if (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //abaixo
            pos.SetValues(pos.row - 1, pos.column - 1);
            if (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //so
            pos.SetValues(pos.row + 1, pos.column - 1);
            if (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //esquerda
            pos.SetValues(pos.row, pos.column - 1);
            if (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            //no
            pos.SetValues(pos.row + 1, pos.column - 1);
            if (board.PositionIsValid(pos) && CanMove(pos))
            {
                mat[pos.row, pos.column] = true;
            }
            return mat;
        }

        public override string ToString()
        {
            return "K";
        }

    }
}