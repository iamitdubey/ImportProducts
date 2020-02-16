using System;
using System.Collections.Generic;
using System.Text;

namespace ImportProducts.Service.Model
{
    public class ImportProductLog
    {
        public int Id { get; set; }
        public string LogMessage { get; set; }
        public string ErrorMessage { get; set; }
        public int LogStatus { get; set; }
    }
}
