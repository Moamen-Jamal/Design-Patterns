namespace Flyweight.Design.Pattern
{
    /// <summary>
    /// The 'FlyweightFactory' class
    /// creates and manages flyweight objects. 
    /// ensures that flyweight are shared properly. When a client requests a flyweight, the FlyweightFactory objects assets an existing instance or creates one, if none exists.
    /// </summary>
    public class PlayerFactory
    {
        private static Dictionary<string, IPlayer> Players = new Dictionary<string, IPlayer>();

        public static IPlayer? GetPlayer(string teamType)
        {
            if (Players.ContainsKey(teamType))
            {
                return Players[teamType];
            }
            else
            {
                switch (teamType)
                {
                    case "RedTeam":
                        var redPlayer = new RedTeamPlayer();
                        Players["RedTeam"] = redPlayer;

                        return redPlayer;
                    case "BlueTeam":
                        var bluePlayer = new BlueTeamPlayer();
                        Players["BlueTeam"] = bluePlayer;
                        return bluePlayer;
                    default:
                        Console.WriteLine("Team is not available");
                        return null;
                        //throw new ArgumentNullException();
                }

            }
        }
    }
}
