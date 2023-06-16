using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizations1
{
    public class Organizations
    {
        private string _name;
        private string _activityField;
        private string _address;

        public string Name 
        { 
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string ActivityField
        {
            get
            {
                return _activityField;
            }
            set
            {
                _activityField = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

    }
}
