using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task
{
    public class MyList<T>:IEnumerable<T>
    {
        private T[] _elements;
        private int _count;

        public MyList()
        {
            _elements = new T[2];
            _count = 0;
        }

        //Add
        public void addElement(T item)
        {
            if (_count == _elements.Length)
            {
                Array.Resize(ref _elements, _elements.Length * 2);
            }
            _elements[_count] = item;
            _count++;
        }

        //AddRange
        public void AddRange(IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                addElement(element);
            }
        }
        //Remove
        public bool removeElement(T element)
        {
            int index = Array.IndexOf(_elements, element);
            if (index >= 0)
            {
                removeElementAt(index);
                return true;
            }
            return false;
        }

        //RemoveRange
        public void removeRange(IEnumerable<T> collection)
        {
            foreach (T element in collection)
            {
                removeElement(element);
            }
        }

        //RemoveAt
        public void removeElementAt(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new ArgumentOutOfRangeException("This argument is out of range.");
            }
            Array.Copy(_elements, index + 1, _elements, index, _count - index - 1);
            _count--;
        }

        //Indexer
        public T getElement(int index)
        {
            if (index >= 0 && index < _count)
            {
                Console.Write("Element with index " + index + ": ");
                return _elements[index];
            }
            else
            {
                throw new IndexOutOfRangeException($"Index {index} in MyList is out of range.");
            }
        }

        //Count
        public int elementsCount()
        {
             return _count;
        }

        //Contains
        public bool isElementInList(T element)
        {
            for (int i = 0; i < _count; i++)
            {
                if(EqualityComparer<T>.Default.Equals(_elements[i], element))
                {
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < _count; i++)
            {
                yield return _elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
