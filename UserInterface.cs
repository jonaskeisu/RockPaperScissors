using System;

namespace RockPaperScissors
{
    static class UserInterface
    {
        static public Player RegisterPlayer()
        {
            Console.Write("Skriv in spelarens namn: ");
            return new Player(Console.ReadLine());
        }

        static public void PresentWinner(Player winner)
        {
            Console.WriteLine($"Vinnaren är: {winner.Name}");
        }

        static public Item SelectSecretItem(Player player)
        {
            Console.WriteLine($"{player.Name}: välj föremål:");
            Console.WriteLine("1. Sten");
            Console.WriteLine("2. Påse");
            Console.WriteLine("3. Sax");
            return (Item)int.Parse(Console.ReadLine());
        }
    }
}