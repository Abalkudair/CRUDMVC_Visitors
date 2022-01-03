using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using visitors.Models;

namespace visitors.Services
{
    public class ExcIVisitor : IVisitor
    {
        private readonly VisitorsDbContext db;

        public ExcIVisitor(VisitorsDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<Visitor> GetAll()
        {
            return from r in db.Visitors
                   select r;
        }

        public void Add(Visitor vistor)
        {
            db.Visitors.Add(vistor);
            db.SaveChanges();
        }
    }
}