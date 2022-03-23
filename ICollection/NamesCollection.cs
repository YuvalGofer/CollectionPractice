using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollection
{
    internal class NamesCollection<T> : ICollection<T>
    {
        public int Count
        {
            get { return _names.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public List<T> _names = new List<T>();

        public bool Contains(T item)
        {
            return _names.Contains(item);
        }

        public void Add(T itemToAdd)
        {
            if (!_names.Contains(itemToAdd))
            {
                _names.Add(itemToAdd);
                Console.WriteLine($"{itemToAdd} was added!");
            }
            else
                Console.WriteLine($"Name: {itemToAdd} was already added!");
        }

        public bool Remove(T itemToRemove)
        {
            if (!_names.Contains(itemToRemove))
            {
                Console.WriteLine($"{itemToRemove} is not in the list!");
            }
            return _names.Remove(itemToRemove);
        }

        public void Clear()
        {
            if (_names.Count == 0)
            {
                Console.WriteLine("List is already cleared!");
            }
            else
                while (_names.Count > 0)
                {
                    _names.RemoveAt(0);
                    Console.WriteLine("Unique list was cleared!");
                }
        }


        public void CopyTo(T[] array, int arrayIndex)
        {
            array = _names.GetRange(arrayIndex, _names.Count).ToArray();
        }


        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in _names)
                yield return item;
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
