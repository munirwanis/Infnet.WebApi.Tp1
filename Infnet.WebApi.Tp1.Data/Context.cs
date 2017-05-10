using Infnet.WebApi.Tp1.Entities;
using System.Data.Entity;

namespace Infnet.WebApi.Tp1.Data
{
    public class Context : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}
