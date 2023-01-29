namespace PatternsApp.Iterator
{
    public interface IIterator<T>
    {
        public void Next();

        public T Current();

        public bool Done();
    }
}