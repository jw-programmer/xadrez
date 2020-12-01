using System;
using Boad;
using Chess;
using xadrez.Screen;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            var boad = new ChessBoad(8, 8);

            boad.PlacePiece(new King(boad, Color.Black), new Position(0,0));
            boad.PlacePiece(new Rook(boad, Color.Black), new Position(1,3));
            boad.PlacePiece(new Rook(boad, Color.Black), new Position(2,4));

            ChessConsole.PrintChessBoad(boad);
            var pos = new Position(1, 4);
            System.Console.WriteLine(pos);
        }
    }
}
