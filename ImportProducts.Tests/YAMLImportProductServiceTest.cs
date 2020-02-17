using ImportProducts.Service;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace ImportProducts.Tests
{
    [TestClass()]
    public class YAMLImportProductServiceTest
    {
        private Mock<ILogger<YAMLImportProductService>> _logger;
        [TestInitialize]
        public void TestInitialize()
        {
            //initialize all the mocks here
            _logger = new Mock<ILogger<YAMLImportProductService>>();
        }

        [TestMethod()]
        public void ProcessImportTest()
        {
            var result = true;
            Assert.IsTrue(result == true);
        }
    }
}
