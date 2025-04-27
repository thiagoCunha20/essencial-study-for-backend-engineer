using DataStructuresStudy.Util;

namespace DataStructuresStudy.DataStructures
{
    public class LinkedList : IDataStructures
    {
        private readonly int[] _dataSource = Data.GenerateRandomArray();
        private int HalfDataSourceLength => _dataSource.Length / 2;
        private readonly LinkedList<int> _linkedList = [];

        public LinkedList() { }

        public void Run()
        {
            AddLast();
            AddBefore();
            Get();
            Remove();
            Clear();
        }

        private void AddLast()
        {
            foreach (var item in _dataSource.Take(HalfDataSourceLength))
            {
                _linkedList.AddLast(item);
            }
            Console.WriteLine($"{_linkedList.Count} items added last to the linked list.");
        }

        private void AddBefore()
        {
            var secondItem = _linkedList?.First?.Next ?? throw new InvalidOperationException("The linked list is empty.");
            foreach (var item in _dataSource.Skip(HalfDataSourceLength).Take(HalfDataSourceLength))
            {
                _linkedList.AddBefore(secondItem, item);
            }
            Console.WriteLine($"Items added before to the linked list.");
        }

        private LinkedListNode<int> Get(int? index = default)
        {
            index ??= GetRandomIndex();
            LinkedListNode<int> currentNode = _linkedList.First ?? throw new InvalidOperationException("The linked list is empty.");
            for (var i = 0; i < index; i++)
            {
                currentNode = currentNode.Next ?? throw new InvalidOperationException("The linked list is empty.");
            }
            Console.WriteLine($"Item at index {index}: {currentNode.Value}");
            return currentNode;
        }

        private void Remove()
        {
            var index = GetRandomIndex();
            var currentNode = Get(index);
            _linkedList.Remove(currentNode);
            Console.WriteLine($"Item at index {index} removed from the linked list.");
        }

        private int GetRandomIndex()
        {
            return new Random().Next(0, _linkedList.Count);
        }

        private void Clear()
        {
            _linkedList.Clear();
            Console.WriteLine("Linked list cleared.");
        }
    }
}
