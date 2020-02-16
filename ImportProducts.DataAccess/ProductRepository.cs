using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImportProducts.DataAccess
{
    public class ProductRepository : IRepository<Product>
    {
        public Task Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
