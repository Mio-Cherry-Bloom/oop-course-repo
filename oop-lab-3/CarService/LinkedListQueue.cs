namespace CarService{
public class LinkedListQueue<T> : IQueue<T>
{
    private class Node
    {
        public T Value;
        public Node Next;

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node _front;
    private Node _back;
    private int _size;

    public LinkedListQueue()
    {
        _front = null;
        _back = null;
        _size = 0;
    }

    public void Enqueue(T item)
    {
        Node newNode = new Node(item);
        if (_back == null)
        {
            _front = _back = newNode;
        }
        else
        {
            _back.Next = newNode;
            _back = newNode;
        }
        _size++;
    }

    public T Dequeue()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        T item = _front.Value;
        _front = _front.Next;
        if (_front == null)
        {
            _back = null;
        }
        _size--;
        return item;
    }

    public T Peek()
    {
        if (_size == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return _front.Value;
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
}