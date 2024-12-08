namespace CarService
{
    public interface ICarQueue
    {
        void Enqueue(Car car);
        Car Dequeue();
        int Count { get; }
    }
public class ListCarQueue : ICarQueue
    {
        private List<Car> queue = new List<Car>();

        public void Enqueue(Car car)
        {
            queue.Add(car);
        }

        public Car Dequeue()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("Queue is empty.");
            
            var car = queue[0];
            queue.RemoveAt(0);
            return car;
        }

        public int Count => queue.Count;
    }
    public class ArrayCarQueue : ICarQueue
    {
        private Queue<Car> queue = new Queue<Car>();

        public void Enqueue(Car car)
        {
            queue.Enqueue(car);
        }

        public Car Dequeue()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return queue.Dequeue();
        }

        public int Count => queue.Count;
    }
    public class LinkedListCarQueue : ICarQueue
    {
        private LinkedList<Car> queue = new LinkedList<Car>();

        public void Enqueue(Car car)
        {
            queue.AddLast(car);
        }

        public Car Dequeue()
        {
            if (queue.Count == 0)
                throw new InvalidOperationException("Queue is empty.");

            var car = queue.First.Value;
            queue.RemoveFirst();
            return car;
        }

        public int Count => queue.Count;
    }

}
