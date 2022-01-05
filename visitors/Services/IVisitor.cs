using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visitors.Models;

namespace visitors.Services
{
    public interface IVisitor
    {
        IEnumerable<Visitor> GetAll();
        void Add(Visitor vistor);
        Visitor Get(int id);
        void Update(Visitor visitor);
    }
}
