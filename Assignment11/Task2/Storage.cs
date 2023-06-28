using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task2
{
    public class Storage<T>
    {
        private List<T> elements;
        public Storage()
        {
            elements = new List<T>();
        }

        public void Add(T element)
        {
            elements.Add(element);
            Console.WriteLine("Added: " + element);
        }

        public void Update(int index, T newElement)
        {
            if (index >= 0 && index < elements.Count)
            {
                elements[index] = newElement;
                Console.WriteLine("Update:" + newElement);
            }
        }

        public void Delete(int index)
        {
            if (index >= 0 && index < elements.Count)
            {
                elements.RemoveAt(index);
                Console.WriteLine("Deleted: " + index);
            }
        }
    }
}
