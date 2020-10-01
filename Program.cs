using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = UserInterface.RegisterPlayer();
            Player player2 = UserInterface.RegisterPlayer();

            Game game = new Game(player1, player2);

            Player winner = game.Play();

            UserInterface.PresentWinner(winner);
        }
    }
}
