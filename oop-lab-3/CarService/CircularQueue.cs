public class CircularQueue<T> : IQueue<T>
{
    private T[] _items;
    private int _front;
    private int _back;
    private int _size;

    public CircularQueue(int capacity = 10)
    {
        _items = new T[capacity];
        _front = 0;
        _back = 0;
        _size = 0;
    }

    public void Enqueue(T item)
    {
        if (_size == _items.Length)
        {
            throw new InvalidOperationException("Queue is full.");
        }
        _items[_back] = item;
        _back = (_back + 1) % _items.Length;
        _size++;
    }

    public T Dequeue()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        T item = _items[_front];
        _front = (_front + 1) % _items.Length;
        _size--;
        return item;
    }

    public T Peek()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return _items[_front];
    }

    public bool IsEmpty()
    {
        return _size == 0;
    }

    public int Size()
    {
        return _size;
    }
}
