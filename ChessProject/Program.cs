using ChessProject.Chess;
using ChessProject.Board;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard(8, 8);

            board.PieceAdd(new King(board, Color.Preta) , new Position(0, 0));
            board.PieceAdd(new King(board, Color.Branca) , new Position(0, 1));

            Screen.PrintBoard(board);
            System.Console.ReadLine();
        }
    }
}