using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StructureToOrganize.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationController : ControllerBase
    {
        StructureToOrganize.Models.OrganizationContext context = new StructureToOrganize.Models.OrganizationContext();
        // GET: api/<OrganizationController>
        [HttpGet]
        public string Get()
        {
            context.Organizations.Add(new Models.Organization() { Name = "MyOrganization", Owner = "TestOwner", OrganizationType = "Social enterprise" });
            context.SaveChanges();
            var organization = context.Organizations.First();
            return String.Concat("Название организации - ", organization.Name,"\nИмя владельца - ",organization.Owner, "\nТип организации - ", organization.OrganizationType,"\nКод организации - ",organization.Code.ToString());
        }

        // GET api/<OrganizationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrganizationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<OrganizationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrganizationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
