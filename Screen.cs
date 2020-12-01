using System;
using Board;

namespace xadrez.Screen
{
    class ChessConsole
    {
        public static void PrintChessBoard(ChessBoard boad)
        {
            for (int i = 0; i < boad.Rows; i++)
            {
                System.Console.Write(8 - i + " ");
                for (var j = 0; j < boad.Columns; j++)
                {
                    if (boad.piece(i, j) == null)
                    {
                        System.Console.Write("= ");
                    }
                    else
                    {
                        PrintChessPiece(boad.piece(i, j));
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintChessPiece(Piece piece)
        {
            if (piece.color == Color.White)
            {
                System.Console.Write(piece);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}