using Microsoft.EntityFrameworkCore;
using StructureToOrganize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.DataAccess
{
    public class OrganizationRepository<T> where T : class
    {
        private readonly OrganizationContext context;
        protected DbSet<T> DBSet;

        public OrganizationRepository(OrganizationContext context)
        {
            this.context = context;
            context.Database.EnsureCreated();
            this.DBSet = this.context.Set<T>();
        }

        public List<T> GetAll()
        {
            return this.DBSet.ToList();
        }

        public T GetById(int id)
        {
            return this.DBSet.Find(id);
        }

        public void Create(T entity)
        {
            var result = this.DBSet.Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            this.DBSet.Update(entity);
            context.SaveChanges();
        }

        public void Remove(T entity)
        {
            this.DBSet.Remove(entity);
            context.SaveChanges();
        }

        public void Remove(int id)
        {
            var entity = this.GetById(id);
            Remove(entity);
        }
    }
}
