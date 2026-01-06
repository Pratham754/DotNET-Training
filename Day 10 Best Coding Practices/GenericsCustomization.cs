namespace MyconsoleApp
{

    public class GenericsCustomization
    {
        public GenericsCustomization()
        {
        }

        public void ExampleOfList()
        {
            List<string> names = [];
        }

        public static void Main()
        {
            MyCollection mc = new();
            mc.Add();
            mc.Clear();
        }
    }


    public class MyCollection : IList
    {
        private object?[] _items = new object?[4]; // Initial capacity
        private int _count = 0;

        public void Add()
        {
            // Simple logic: add a placeholder or value and resize if needed
            if (_count == _items.Length)
            {
                Array.Resize(ref _items, _items.Length * 2);
            }
            _items[_count++] = "New Item";
        }

        public void Clear()
        {
            // Reset the internal array and count
            Array.Clear(_items, 0, _count);
            _count = 0;
        }

        public bool Contains(object? value)
        {
            // Linear search for the value
            for (int i = 0; i < _count; i++)
            {
                if (Equals(_items[i], value)) return true;
            }
            return false;
        }

        public void CopyTo(Array array, int index)
        {
            // Copies elements to the provided array starting at 'index'
            if (array == null) throw new ArgumentNullException(nameof(array));
            Array.Copy(_items, 0, array, index, _count);
        }

    }

    public interface IList
    {
        void Add();
        void Clear();
        bool Contains(object? value);
        void CopyTo(Array array, int index);
    }
}
