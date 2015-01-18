
using System.Collections.Generic;


namespace ObserverPattern
{
    public class YoutubeChannel
    {
        private static YoutubeChannel _youtubeChannel;
        private YoutubeChannel(){}

        public static YoutubeChannel GetInstance()
        {
            return _youtubeChannel ?? (_youtubeChannel = new YoutubeChannel());
        }

        private readonly IList<ISubscriber> _listOfSubscribers = new List<ISubscriber>(); 
        public void Subscribe(ISubscriber subscriber)
        {
            _listOfSubscribers.Add(subscriber);
        }

        public void UnSubscribe(ISubscriber subscriber)
        {
            _listOfSubscribers.Remove(subscriber);
        }

        public void Upload(string username)
        {
            foreach (var subscriber in _listOfSubscribers)
            {
                subscriber.Notify(username);
            }
        }
    }
}
