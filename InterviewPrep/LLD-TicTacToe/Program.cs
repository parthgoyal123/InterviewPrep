using LLD_TicTacToe.Model;

namespace LLD_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create two new players with X and O pieces
            Player player1 = new Player("Player 1", new PlayingPieceX());
            Player player2 = new Player("Player 2", new PlayingPieceO());

            // Create a TicTacToe game with the two players
            TicTacToeGame game = new TicTacToeGame(player1, player2);
            game.Play();
        }
    }
}
