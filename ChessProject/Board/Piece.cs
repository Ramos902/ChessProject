namespace ChessProject.Board
{
    class Piece
    {
        public Position Position { get; set; }
        public Board Board { get; protected set; }
        public Color Color { get; protected set; }
        public int QtyMoves { get; protected set; }

        public Piece(Position position, Board board, Color color)
        {
            this.Position = position;
            this.Board = board;
            this.Color = color;
            this.QtyMoves = 0;
        }
    }
}