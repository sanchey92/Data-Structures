using System.Collections;
using System.Collections.Generic;

namespace BinaryHeap
{
    public class BinaryHeap : IEnumerable
    {
        private List<int> _items = new List<int>();
        public int Count => _items.Count;

        public BinaryHeap() { }

        public BinaryHeap(IEnumerable<int> items)
        {
            _items.AddRange(items);
            for (var i = Count; i >= 0; i--)
                Sort(i);
        }

        public int? Peek() => Count > 0 ? _items[0] : null;

        public void Add(int item)
        {
            _items.Add(item);

            var currentIndex = Count - 1;
            var parentIndex = GetParentIndex(currentIndex);

            while (currentIndex > 0 && _items[parentIndex] < _items[currentIndex])
            {
                Swap(currentIndex, parentIndex);

                currentIndex = parentIndex;
                parentIndex = GetParentIndex(currentIndex);
            }
        }

        public int GetMax()
        {
            var result = _items[0];
            _items[0] = _items[Count - 1];
            _items.RemoveAt(Count - 1);
            Sort(0);
            return result;
        }

        private void Sort(int currentIndex)
        {
            var maxIndex = currentIndex;
            int leftIndex;
            int rightIndex;

            while (currentIndex < Count)
            {
                leftIndex = 2 * currentIndex + 1;
                rightIndex = 2 * currentIndex + 2;

                if (leftIndex < Count && _items[leftIndex] > _items[maxIndex])
                    maxIndex = leftIndex;

                if (rightIndex < Count && _items[rightIndex] > _items[maxIndex])
                    maxIndex = rightIndex;

                if (maxIndex == currentIndex) break;

                Swap(currentIndex, maxIndex);
            }
        }

        private static int GetParentIndex(int index) => (index - 1) / 2;

        private void Swap(int index1, int index2)
        {
            var temp = _items[index1];
            _items[index1] = _items[index2];
            _items[index2] = temp;
        }

        public IEnumerator GetEnumerator()
        {
            while (Count > 0) yield return GetMax();
        }
    }
}