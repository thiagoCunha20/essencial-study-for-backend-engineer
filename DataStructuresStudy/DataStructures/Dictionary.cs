using DataStructuresStudy.Util;

namespace DataStructuresStudy.DataStructures
{
    public class Dictionary : IDataStructures
    {
        private readonly int[] _dataSource = Data.GenerateRandomArray();
        private int HalfDataSourceLength => _dataSource.Length / 2;
        private readonly Dictionary<string, int> _dictionary = [];

        public Dictionary() { }

        public void Run()
        {
            Fill();
            Peek();
            Pop();
            Clear();
        }

        private void Fill()
        {
            foreach (var item in _dataSource.Take(HalfDataSourceLength))
            {
                _dictionary.Add(, item);
            }
            Console.WriteLine($"{_stack.Count} items added to the stack.");
        }

        private void Peek()
        {
            Console.WriteLine($"The item from top of stack is {_stack.Peek()} (Peek).");
        }

        private void Pop()
        {
            Console.WriteLine($"The item from top of stack ({_stack.Pop()}) was removed.");
        }

        private void Clear()
        {
            _stack.Clear();
            Console.WriteLine("Stack cleared.");
        }
    }
}
