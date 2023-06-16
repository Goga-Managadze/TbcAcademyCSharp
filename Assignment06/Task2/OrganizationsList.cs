using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organizations1
{
    public class OrganizationList
    {
        private Organizations[] _OrganizationList;
        private int count = 0;
        private bool IsFound = false;
        public Organizations this[int i]
        {
            get
            {
                return _OrganizationList[i];
            }
            set
            {
                _OrganizationList[i] = value;
            }
        }
        public int setOrganizations
        {
            set
            {
                _OrganizationList = new Organizations[value];
            }
        }

        public void AddElement(Organizations Organization)
        {
            if (count < _OrganizationList.Length)
            {
                _OrganizationList[count] = Organization;
                count++;
            }
            Console.WriteLine($"Added Organization: Name: {Organization.Name}, Activity Field: {Organization.ActivityField}, Address: {Organization.Address}");
        }

        public void AddList(Organizations[] Organization)
        {
            for (int i = 0; i < Organization.Length; i++)
            {
                if (count < _OrganizationList.Length)
                {
                    _OrganizationList[count] = Organization[i];
                    count++;
                }
                Console.WriteLine($" Organization added . Name: {Organization[i].Name}");
            }
        }

        public void GetElement(int index)
        {
            for (int j = 0; j < _OrganizationList.Length; j++)
            {
                if (index == j)
                {
                    Console.WriteLine("Your element is : " + _OrganizationList[j].Name);
                    break;
                }
            }
        }

        public void RemoveElement(Organizations Organization)
        {
            for (int i = 0; i < _OrganizationList.Length; i++)
            {
                if (_OrganizationList[i] == Organization)
                {
                    _OrganizationList[i] = null;
                    count--;
                    Console.WriteLine($" Organization {Organization.Name} removed");
                    break;
                }
            }
        }

        public void RemoveList(Organizations[] Organization)
        {
            for (int i = 0; i < _OrganizationList.Length; i++)
            {
                if (_OrganizationList[i] == Organization[i])
                {
                    _OrganizationList[i] = null;

                    Console.WriteLine($"{Organization[i].Name} This Organization removed");
                    count--;
                    break;
                }
            }
        }

        public void ClearList()
        {
            for (int i = 0; i < _OrganizationList.Length; i++)
            {
                _OrganizationList[i] = null;
                count--;
                break;
            }
            Console.WriteLine("Organizations List is Clear");
        }

        public string FindOrganization(string i)
        {
            for (int j = 0; j < _OrganizationList.Length; j++)
            {
                if (i == _OrganizationList[j].Name)
                {
                    Console.WriteLine("Found: " + i);
                    break;
                }
            }
            return i;
        }

        public void OrganizationsCount()
        {
            Console.WriteLine("Organizations Count:" + count);

        }
    }
}


    

