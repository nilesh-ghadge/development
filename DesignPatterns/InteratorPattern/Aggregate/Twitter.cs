
using InteratorPattern.Iterator;

namespace InteratorPattern.Aggregate
{
    public class Twitter : ISocialNetworking
    {
        private static string[] _users;
        private IIterator _iterator;

        public Twitter()
        {
            _users = new[] {"Mangesh", "Rupesh", "Gargi"};
        }

        public IIterator CreateIterator()
        {
            _iterator = new TwitterIterator(_users);
            return _iterator;
        }
    }
}
