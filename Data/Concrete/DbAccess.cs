using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete
{
    public class DbAccess : DbContext
    {
        public DbAccess()
        {

        }

        public DbAccess(DbContextOptions options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<SideBar> SideBars { get; set; }
    }
}
