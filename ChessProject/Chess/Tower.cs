using ChessProject.Board;

namespace ChessProject.Chess
{
    class Tower : Piece
    {
        public Tower(ChessBoard board, Color color) : base(board, color)
        {
        }
        public override string ToString()
        {
            return "T";
        }
    }
}