using ImportProducts.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImportProducts.Service
{
    public interface IImportProductService
    {
        ImportProductLog ImportProductLog { get; set; }
        Task ProcessImport(); // Download file, process/transform and store in the DB
    }
}
