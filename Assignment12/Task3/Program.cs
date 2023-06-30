// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Running;
using Task3;

List<Organization> createOrganizations(int count)
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


List<Organization> organizations = createOrganizations(150);


foreach (Organization organization in organizations)
{
    Console.WriteLine($"Organization Name: {organization.Name}");
}

BenchmarkRunner.Run<BenchmarkTest>();