using ImportProducts.Service.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ImportProducts.Service
{
    public class YAMLImportProductService : IImportProductService
    {
        public ImportProductLog ImportProductLog { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Task ProcessImport()
        {
            throw new NotImplementedException();
        }
    }
}
