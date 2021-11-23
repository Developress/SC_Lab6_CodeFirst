using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab6.Models;

namespace Lab6
{
    class ITCompanyContext: DbContext
    {
        public ITCompanyContext(): base()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ITCompanyContext, Lab6.Migrations.Configuration>());
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
