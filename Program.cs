using System;
using Board;
using Chess;
using xadrez.Screen;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var board = new ChessBoard(8, 8);

            board.PlacePiece(new King(board, Color.Black), new Position(0,0));
            board.PlacePiece(new Rook(board, Color.Black), new Position(1,3));
            board.PlacePiece(new Rook(board, Color.Black), new Position(2,4));
            board.PlacePiece(new King(board, Color.White), new Position(0,0));

            ChessConsole.PrintChessBoard(board);
            var pos = new Position(1, 4);
            System.Console.WriteLine(pos);
            }catch(BoardException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
