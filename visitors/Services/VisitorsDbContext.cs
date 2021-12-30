using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using visitors.Models;

namespace visitors.Services
{
    public class VisitorsDbContext : DbContext
    {
        public DbSet<Visitor> Visitors { get; set; }
    }
}