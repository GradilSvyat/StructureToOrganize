using StructureToOrganize.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Services
{
    public class UserService
    {
        private readonly AuthenticationDBContext context;
        internal UserService(AuthenticationDBContext context)
        {
            this.context = context;
        }
        public virtual User GetUser (int id)
        {
            return context.Find<User>(id);
        }
        public virtual void UpdateUser (User user)
        {
            context.Update<User>(user);
            context.SaveChangesAsync();
        }
        public virtual void CreateUser(User user)
        {
            context.Add<User>(user);
            context.SaveChangesAsync();
        }
        public virtual void DeleteUser (int id)
        {
            var entity = context.Find<User>(id);
            context.Remove<User>(entity);
            context.SaveChangesAsync();
        }
    }
}
