using System;
using System.Collections.Generic;
using System.Text;

namespace ImportProducts.DataAccess
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
    }
}
