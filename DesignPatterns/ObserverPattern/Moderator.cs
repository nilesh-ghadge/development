using System;


namespace ObserverPattern
{
    public class Moderator : ISubscriber
    {
        private string moderatorName;
        public Moderator()
        {
            moderatorName = "<no-moderator-name>";
        }

        public Moderator(string username)
        {
            moderatorName = username;
        }

        public void Notify(string username)
        {
            Console.WriteLine("Hello {0},'{1}' has uploaded a new video. Please review", moderatorName, username);
        }
    }
}