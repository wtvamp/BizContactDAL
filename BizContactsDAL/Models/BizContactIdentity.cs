using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BizContacts.DAL
{
    /// <summary>
    /// Context for working with ASP.Net Identities
    /// </summary>
    class BizContactIdentityContext : DbContext
    {
        public BizContactIdentityContext(DbContextOptions<BizContactContext> options)
            : base(options)
        { }

        public DbSet<BizContactIdentity> BizContactIdentities { get; set; }
    }

    /// <summary>
    /// A user stored using ASP.NET Identity
    /// </summary>
    public class BizContactIdentity: IdentityUser
    {
        // Extended Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
