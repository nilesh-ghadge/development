
using System.Collections.Generic;
using System.Linq;


namespace InteratorPattern.Iterator
{
    public class FacebookIterator : IIterator
    {
        private readonly LinkedList<string> _facebookUsers;
        private int _position;

        public FacebookIterator(LinkedList<string> users)
        {
            _facebookUsers = users;
            _position = 0;
        }
        public void First()
        {
            _position = 0;
        }

        public bool IsDone()
        {
            return _position >= _facebookUsers.Count();
        }

        public string Next()
        {
            return _facebookUsers.ElementAt(_position++);
        }

        public string CurrentItem()
        {
            return _facebookUsers.ElementAt(_position);
        }
    }
}
