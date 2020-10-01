namespace RockPaperScissors
{
    class Player
    {
        private Item secretItem;
        private string name;

        public string Name 
        {
            get { return name; }
            private set { name = value; }
        } 


        public Item SecretItem 
        {
            get { return secretItem; }
            private set { secretItem = value; }
        } 

        public Player(string name)
        {
            Name = name;
        }

        public void SelectSecretItem()
        {    
            SecretItem = UserInterface.SelectSecretItem(this);     
        }
    }
}