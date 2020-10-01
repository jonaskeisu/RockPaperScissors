namespace RockPaperScissors
{
    class Game
    {
        private Player[] players;

        private Player[] Players
        {
            get { return players; }

            set { players = value; }
        }

        public Game(Player player1, Player player2)
        {
            Players = new Player[2];
            Players[0] = player1;
            Players[1] = player2;
        }

        public Player Play()
        {
            while (true)
            {
                Players[0].SelectSecretItem();
                Players[1].SelectSecretItem();

                Item item1 = Players[0].SecretItem;
                Item item2 = Players[1].SecretItem;

                if (item1 != item2)
                {
                    switch (item1)
                    {
                        case Item.Paper:
                            return item2 == Item.Rock ?
                                Players[0] :
                                Players[1];
                        case Item.Rock:
                            return item2 == Item.Scissors ?
                                Players[0] :
                                Players[1];
                        default:
                            return item2 == Item.Paper ?
                                Players[0] :
                                Players[1];
                    }
                }
            }
        }
    }
}