using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BizContacts.DAL
{
    class BizContactIdentityContext: DbContext
    {
        public BizContactIdentityContext(DbContextOptions<BizContactContext> options)
            : base(options)
        { }

        public DbSet<BizContactIdentity> BizContactIdentities { get; set; }
    }

    public class BizContactIdentity: IdentityUser
    {
        // Extended Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
