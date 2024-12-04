namespace CarServiceApplication
{
    public class Queue<T>
    {
        private readonly List<T> _items;

        public Queue()
        {
            _items = new List<T>();
        }

        public void Enqueue(T item)
        {
            _items.Add(item);
        }

        public T Dequeue()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            T item = _items[0];
            _items.RemoveAt(0);
            return item;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            return _items[0];
        }

        public bool IsEmpty()
        {
            return _items.Count == 0;
        }

        public int Count()
        {
            return _items.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);

            Console.WriteLine($"Dequeued: {intQueue.Dequeue()}");
            Console.WriteLine($"Peek: {intQueue.Peek()}");

            Queue<string> stringQueue = new Queue<string>();
            stringQueue.Enqueue("Car1");
            stringQueue.Enqueue("Car2");
            stringQueue.Enqueue("Car3");

            Console.WriteLine($"Dequeued: {stringQueue.Dequeue()}");
            Console.WriteLine($"Peek: {stringQueue.Peek()}");
        }
    }
}
