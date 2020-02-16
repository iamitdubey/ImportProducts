using ImportProducts.Service.Model;
using System;
using System.Threading.Tasks;

namespace ImportProducts.Service
{
    public interface ILoggerService
    {
        Task<decimal> InfoLogInsert(ImportProductLog importProductLogLog);
        Task InfoLogUpdate(ImportProductLog importProductLogLog);
        Task ErrorLogUpdate(ImportProductLog importProductLogLog);
        Task InsertError(ImportProductLog importProductLogLog);
    }
}
