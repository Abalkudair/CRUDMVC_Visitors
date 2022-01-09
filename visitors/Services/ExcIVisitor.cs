using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public Visitor Get(int id)
        {
            return db.Visitors.SingleOrDefault(r => r.Id == id);
        }
        public void Update(Visitor visitor)
        {
            var entry = db.Entry(visitor);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var visitor = db.Visitors.Find(id);
            db.Visitors.Remove(visitor);
            db.SaveChanges();
        }
    }
}