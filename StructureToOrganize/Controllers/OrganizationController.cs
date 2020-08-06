using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using StructureToOrganize.Models;

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
        public IEnumerable<string> Get()
        {
            //context.Organizations.Add(new Models.Organization() 
            //{ Name = "MyOrganization", 
            //    Owner = "Owner", 
            //    OrganizationType = "Incorporated company", 
            //    Code = 475, Countries = new List<Country>() { new Country() { Code = 804, Name = "Украина" } }
            //});
            //context.SaveChanges();
            var organization = context.Organizations.ToList<Organization>();
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
            return "value";
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
