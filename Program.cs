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
                var match = new ChessMatch();
                ChessConsole.PrintChessBoard(match.Board);
                var pos = new Position(1, 4);
                System.Console.WriteLine(pos);
                
                // ChessPosition pos = new ChessPosition('c',7);
                // System.Console.WriteLine(pos);

                // System.Console.WriteLine(pos.ToPosition());
            }
            catch (BoardException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
