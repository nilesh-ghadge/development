using System;


namespace ObserverPattern
{
    public class User : ISubscriber
    {
        private string _userName;
        public User()
        {
            _userName = "<no-username>";
        }
        
        public User(string username)
        {
            _userName = username;
        }

        public void Notify(string username)
        {
            Console.WriteLine("Hello {0},'{1}' has uploaded a new video", _userName, username);
        }

        public void Upload()
        {
            Console.WriteLine("Upload successful!!");
            var channel = YoutubeChannel.GetInstance();
            channel.Upload(_userName);

        }


    }
}
