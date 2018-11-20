using Microsoft.EntityFrameworkCore;

namespace BizContacts.DAL
{
    /// <summary>
    /// Context for working with the business contact database
    /// </summary>
    public class BizContactContext : DbContext
    {
        public BizContactContext(DbContextOptions<BizContactContext> options)
            : base(options)
        { }

        public DbSet<BizContact> BizContacts { get; set; }
    }

    /// <summary>
    /// Data Model for a Business contact
    /// </summary>
    public class BizContact
    {
        public int BizContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
}