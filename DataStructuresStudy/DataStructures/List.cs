using DataStructuresStudy.Util;

namespace DataStructuresStudy.DataStructures
{
    public class List : IDataStructures
    {
        private readonly int[] _dataSource = Data.GenerateRandomArray();
        private readonly List<int> _list = [];

        public List() { }

        public void Run()
        {
            Add();
            Get();
            Remove();
            Clear();
        }

        private void Add()
        {
            foreach (var item in _dataSource)
            {
                _list.Add(item);
            }
            Console.WriteLine($"{_list.Count} items added to the list.");
        }

        private void Get()
        {
            var index = GetRandomIndex();
            var item = _list[index];
            Console.WriteLine($"Item at index {index}: {item}");
        }

        private void Remove()
        {
            var index = GetRandomIndex();
            _list.RemoveAt(index);
            Console.WriteLine($"Item at index {index} removed from the list.");
        }

        private int GetRandomIndex()
        {
            return new Random().Next(0, _list.Count);
        }

        private void Clear()
        {
            _list.Clear();
            Console.WriteLine("List cleared.");
        }
    }
}
