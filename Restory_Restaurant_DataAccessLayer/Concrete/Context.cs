using Microsoft.EntityFrameworkCore;
using Restory_Restaurant_EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restory_Restaurant_DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options) : base(options)
        {
        }
        public DbSet<About>Abouts  { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PopularFlavor> PopularFlavors { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Introduction> Introductions { get; set; }

    }
}
