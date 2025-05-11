using DataStructuresStudy.Util;

namespace DataStructuresStudy.DataStructures
{
    public class Queue : IDataStructures
    {
        private readonly int[] _dataSource = Data.GenerateRandomArray();
        private int HalfDataSourceLength => _dataSource.Length / 2;
        private readonly Queue<int> _queue = [];

        public Queue() { }

        public void Run()
        {
            Fill();
            Peek();
            Dequeue();
            Clear();
        }

        private void Fill()
        {
            foreach (var item in _dataSource.Take(HalfDataSourceLength))
            {
                _queue.Enqueue(item);
            }
            Console.WriteLine($"{_queue.Count} items added to the queue.");
        }

        private void Peek()
        {
            Console.WriteLine($"The first item of queue is {_queue.Peek()} (Peek).");
        }

        private void Dequeue()
        {
            Console.WriteLine($"The first item of queue ({_queue.Dequeue()}) was removed.");
        }

        private void Clear()
        {
            _queue.Clear();
            Console.WriteLine("Queue cleared.");
        }
    }
}
