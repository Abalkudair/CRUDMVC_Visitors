using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using visitors.Models;

namespace visitors.Services
{
    internal interface IVisitor
    {
        Visitor Add(Visitor vistor);
    }
}
