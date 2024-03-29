﻿namespace Mediator.Design.Pattern
{
    /// <summary>
    /// The 'ConcreteMediator' class
    /// Concrete Mediators implement cooperative behavior by coordinating several
    /// components.
    /// </summary>
    public class ConcreteFacebookGroupMediator : FacebookGroupMediator
    {
        private List<User> usersList = new List<User>();
        public void RegisterUser(User user)
        {
            usersList.Add(user);
        }
        public void SendMessage(string message, User user)
        {
            foreach (var u in usersList)
            {
                // message should not be received by the user sending it
                if (u != user)
                {
                    u.Receive(message);
                }
            }
        }
    }
}
