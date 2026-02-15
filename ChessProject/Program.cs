using Chess.Board;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            Position P;

            P = new(3,5);

            System.Console.WriteLine("Posição: " + P);
            System.Console.ReadLine();
        }
    }
}