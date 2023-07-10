using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class FilterMethods
    {
        public static bool searchFirstname(Contacts contact, string param)
        {
            return contact.Firstname.ToUpper().Contains(param.ToUpper());
        }

        public static bool searchLastname(Contacts contact, string param)
        {
            return contact.Lastname.ToUpper().Contains(param.ToUpper());
        }

        public static bool searchFirstnameLastname(Contacts contact, string param)
        {
            return (contact.Firstname + " " + contact.Lastname).ToUpper().Contains(param.ToUpper());
        }
    }
}
