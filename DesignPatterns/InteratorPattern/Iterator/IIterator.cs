namespace InteratorPattern.Iterator
{
    public interface IIterator
    {
        void First();
        bool IsDone();
        string Next();
        string CurrentItem();
    }
}
