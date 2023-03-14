namespace Memento.Design.Pattern
{
    /// <summary>
    /// The 'Originator' class
    /// The Originator class can produce snapshots of its own state, as well as restore its state from snapshots when needed.
    /// </summary>
    public class GameOriginator
    {
        public string playerName { get; set; }
        public int playerScore { get; set; }
        public GameOriginator(string playerName, int playerScore)
        {
            this.playerName = playerName;
            this.playerScore = playerScore;
        }

        public CheckPointMemento Save()
        {
            return new CheckPointMemento(playerName, playerScore);
        }

        public void Revert(CheckPointMemento revGame)
        {
            playerName = revGame.GetPlayerName();
            playerScore = revGame.GetPlayerScore();
        }
    }
}
