using StructureToOrganize.DataAccess;
using StructureToOrganize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Services
{
    public class OrganizationService
    {
        private readonly OrganizationRepository<Organization> organizationRepository;
        private readonly OrganizationRepository<Country> countryRepository;
        private readonly OrganizationRepository<Business> businessRepository;
        public OrganizationService(OrganizationRepository<Organization> organizationRepository, OrganizationRepository<Country> countryRepository, OrganizationRepository<Business> businessRepository)
        {
            this.organizationRepository = organizationRepository;
            this.countryRepository = countryRepository;
            this.businessRepository = businessRepository;
        }
        public virtual List<Organization> GetOrganizations()
        {
            return organizationRepository.GetAll();
        }
        public virtual Organization GetOrganization(int id)
        {
            return organizationRepository.GetById(id);
        }
        public virtual void CreateOrganization (Organization organization)
        {
            organizationRepository.Create(organization);
        }
        public virtual void UpdateOrganization (Organization organization)
        {
            organizationRepository.Update(organization);
        }
        public virtual void DeleteOrganization (int id)
        {
            organizationRepository.Remove(id);
        }
    }
}
