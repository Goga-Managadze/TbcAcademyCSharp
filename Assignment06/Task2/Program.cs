
using Organizations1;
using System;

Organizations Organization = new Organizations { Name = "Organization", ActivityField = "Activity", Address = "Address" };
Organizations Organization1 = new Organizations { Name = "Organization1", ActivityField = "Activity1", Address = "Address1" };
Organizations Organization2 = new Organizations { Name = "Organization2", ActivityField = "Activity2", Address = "Address2" };
Organizations Organization3 = new Organizations { Name = "Organization3", ActivityField = "Activity3", Address = "Address3" };

OrganizationList organizationList = new OrganizationList();
Organizations[] organizationsAddList = new Organizations[] { Organization, Organization1, Organization2, Organization3 };

organizationList.setOrganizations = 10;
organizationList.AddElement(Organization);
organizationList.AddElement(Organization1);
organizationList.AddElement(Organization2);
organizationList.AddElement(Organization3);

organizationList.GetElement(1);
organizationList.AddList(organizationsAddList);

//organizationList.RemoveElement(Organization2);

//Organizations[] organizationsRemoveList = new Organizations[] { Organization2, Organization3 };
//organizationList.RemoveList(organizationsRemoveList);
//organizationList.ClearList();
//organizationList.FindOrganization("Organization");
//organizationList.OrganizationsCount();