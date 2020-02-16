using ImportProducts.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImportProducts.Service
{
    public class LoggerService : ILoggerService
    {
        public Task ErrorLogUpdate(ImportProductLog importProductLogLog)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> InfoLogInsert(ImportProductLog importProductLogLog)
        {
            throw new NotImplementedException();
        }

        public Task InfoLogUpdate(ImportProductLog importProductLogLog)
        {
            throw new NotImplementedException();
        }

        public Task InsertError(ImportProductLog importProductLogLog)
        {
            throw new NotImplementedException();
        }
    }
}
