

namespace InteratorPattern.Iterator
{
    public class TwitterIterator : IIterator
    {
        private readonly string[] _twitterUsers;
        private int _position;

        public TwitterIterator(string[] users)
        {
            _twitterUsers = users;
            _position = 0;
        }
        public void First()
        {
            _position = 0;
        }

        public bool IsDone()
        {
            return _position >= _twitterUsers.Length;
        }

        public string Next()
        {
            return _twitterUsers[_position++];
        }

        public string CurrentItem()
        {
            return _twitterUsers[_position];
        }
    }
}
