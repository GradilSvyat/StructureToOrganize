using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace StructureToOrganize
{
    internal class AplicationDBContext: IdentityDbContext<IdentityUser>
    {
    }
}