using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class BookNotFoundException : ApplicationException
    {
        public BookNotFoundException(int bookNumber) : base($"Book with number '{bookNumber}' was not found.")
        {
        }
    }

}
