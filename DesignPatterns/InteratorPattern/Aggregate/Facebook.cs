
using System.Collections.Generic;
using InteratorPattern.Iterator;


namespace InteratorPattern.Aggregate
{
    public class Facebook : ISocialNetworking
    {
        private static LinkedList<string> _users;
        private IIterator _iterator;

        public Facebook()
        {
            _users = new LinkedList<string>();
            _users.AddLast("Nilesh");
            _users.AddLast("Shweta");
            _users.AddLast("Chandar");
            _users.AddLast("Pushpa");
        }

        public IIterator CreateIterator()
        {
            _iterator = new FacebookIterator(_users);
            return _iterator;
        }
    }
}
