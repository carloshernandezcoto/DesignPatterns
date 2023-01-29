namespace PatternsApp.Iterator
{
    public class StackIterator<T> : IIterator<T>
    {
        private Stack<T> stack;

        public StackIterator(Stack<T> stack)
        {
            this.stack = stack;
        }

        public T Current()
        {
            return stack.Peek();
        }

        public bool Done()
        {
            return stack.Count == 0;
        }

        public void Next()
        {
            stack.Pop();
        }
    }
}