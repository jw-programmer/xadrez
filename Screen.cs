using System;
using Board;
using Chess;

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
                    PrintChessPiece(boad.piece(i, j));
                    Console.Write(" ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
        }

        public static void PrintChessBoard(ChessBoard boad, bool[,] possibleMoves)
        {
            ConsoleColor oringBack = Console.BackgroundColor;
            ConsoleColor altBack = ConsoleColor.DarkGray;

            for (int i = 0; i < boad.Rows; i++)
            {
                System.Console.Write(8 - i + " ");
                for (var j = 0; j < boad.Columns; j++)
                {
                    if(possibleMoves[i,j])
                    {
                        Console.BackgroundColor = altBack;
                    }else{
                        Console.BackgroundColor = oringBack;
                    }
                    PrintChessPiece(boad.piece(i, j));
                    Console.Write(" ");
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine("  a b c d e f g h");
            Console.BackgroundColor = oringBack;
        }

        public static void PrintChessPiece(Piece piece)
        {
            if (piece == null)
            {
                Console.Write("=");
            }
            else
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

        public static ChessPosition ReadChessPositon()
        {
            string s = Console.ReadLine();
            char column = s[0];
            int row = int.Parse(s[1] + "");
            return new ChessPosition(column, row);
        }
    }
}