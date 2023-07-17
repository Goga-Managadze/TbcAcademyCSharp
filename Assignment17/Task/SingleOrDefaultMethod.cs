using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public static class SingleOrDefaultMethod
    {
        public static T singleOrDefaultMethods<T>(this IEnumerable<T> list, Func<T, bool> predicate)
        {
            T result = default(T);
            bool found = false;

            foreach (T element in list)
            {
                if (predicate(element))
                {
                    if (found)
                    {
                        throw new InvalidOperationException("There is more than one matching element.");
                    }

                    result = element;
                    found = true;
                }
            }
            return result;
        }
    }
}
