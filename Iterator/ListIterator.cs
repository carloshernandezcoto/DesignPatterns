namespace PatternsApp.Iterator
{
    public class ListIterator<T> : IIterator<T>
    {
        private List<T> list;
        private int index = 0;

        public ListIterator(List<T> list)
        {
            this.list = list;
        }

        public T Current()
        {
            return list[index];
        }

        public bool Done()
        {
            return index == list.Count;
        }

        public void Next()
        {
            index++;
        }
    }
}