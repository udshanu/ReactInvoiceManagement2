using InvoiceManagementApp2.Entities.Common;
using InvoiceManagementApp2.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InvoiceManagementApp2.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Books> Books { get; set; }
        public DbSet<Invoice> Invoice { get; set; }
        public DbSet<InvoiceItem> InvoiceItem { get; set; }

        public override int SaveChanges()
        {
            foreach (var changeRecord in this.ChangeTracker.Entries().Where(x => x.Entity is Entity && (x.State == EntityState.Added || x.State == EntityState.Modified)).Select(e => e.Entity as Entity))
            {
                if (changeRecord.DateLastUpdated == DateTime.MinValue)
                {
                    //Set Update Date
                    changeRecord.DateLastUpdated = DateTime.Now;
                }


                //Set Created Date
                if (changeRecord.DateCreated == DateTime.MinValue)
                {
                    changeRecord.DateCreated = DateTime.Now;
                }
            }

            return base.SaveChanges();
        }
    }
}
