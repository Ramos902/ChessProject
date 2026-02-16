using ChessProject.Board;

namespace ChessProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessBoard board = new ChessBoard(8,8);
            
            Screen.PrintBoard(board);
            System.Console.ReadLine();
        }
    }
}