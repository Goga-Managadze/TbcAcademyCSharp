using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace Task3
{
    public class BenchmarkTest
    {

        //List<Organization> organizations = GenerateOrganizations(50);

        [Benchmark]
        public void Test()
        {
            List<Organization> GenerateOrganizations(int count)
            {
                List<Organization> organizations = new List<Organization>();
                string[] names = { "OrganizationA", "OrganizationB", "OrganizationC", "OrganizationD" };

                for (int i = 0; i < count; i++)
                {
                    Organization organization = new Organization
                    {
                        Name = names[i % names.Length]
                    };

                    organizations.Add(organization);
                }
                return organizations;
            }
        }
    }
}
