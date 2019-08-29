using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogUygulama.Core.Entities.Abstract;

namespace BlogUygulama.Core.Entities.Concrete
{
    public class Entity : IEntity
    {
        public int ID { get; set ; }
        
    }
}
