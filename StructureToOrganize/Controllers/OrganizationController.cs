using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StructureToOrganize.Models;
using StructureToOrganize.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StructureToOrganize.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        OrganizationContext context = new OrganizationContext();
        private readonly OrganizationService organizationService;
        public OrganizationController(OrganizationService organizationService)
        {
            this.organizationService = organizationService;
        }
        // GET: api/<OrganizationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var organization = organizationService.GetOrganizations();
                //context.Organizations.ToList<Organization>();
            var countries = context.Countries.ToList<Country>();
            List<string> result = new List<string>();
            foreach (var item in organization)
            {
                result.Add(String.Concat("Название организации - ", item.Name, "\nИмя владельца - ", item.Owner, "\nТип организации - ", item.OrganizationType, "\nКод организации - ", item.Code.ToString()));
            }
            foreach (var item in countries)
                result.Add((String.Concat(item.Name,item.Code, item.Organization.Name)));
            return result;
        }

        // GET api/<OrganizationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return this.organizationService.GetOrganization(id).Name; ;
        }

        // POST api/<OrganizationController>
        [Authorize]
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrganizationController>/5
        [Authorize]
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrganizationController>/5
        [Authorize]
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
