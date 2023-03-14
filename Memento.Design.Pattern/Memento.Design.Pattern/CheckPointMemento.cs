namespace Memento.Design.Pattern
{
    /// <summary>
    /// The 'Memento' class
    /// The Memento is a value object that acts as a snapshot of the originator’s state. 
    /// It’s a common practice to make the memento immutable and pass it the data only once, via the constructor.
    /// </summary>
    public class CheckPointMemento
    {
        private string playerName { get; set; }
        private int playerScore { get; set; }
        public CheckPointMemento(string playerName, int playerScore)
        {
            this.playerName = playerName;
            this.playerScore = playerScore;
        }

        public string GetPlayerName()
        {
            return playerName;
        }
        public int GetPlayerScore()
        {
            return playerScore;
        }
    }
}
