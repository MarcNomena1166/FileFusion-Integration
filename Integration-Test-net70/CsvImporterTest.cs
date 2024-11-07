using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileFusion;
using FileFusionClass = FileFusion.FileFusion;

namespace Integration_Test_net70
{
    internal class CsvImporterTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetDataFeomCSVTest()
        {
            try
            {
                List<string> escapeChar = new List<string> { "/", "(", ")", ".", " " };

                string path = System.AppContext.BaseDirectory;
                string file = "Test.csv";

                List<object>? result = FileFusionClass.Extract<SimpleData>(file, path, escapeChar, 3); // Use the correct class name
                int count = 0;
                bool validity = false;
                const int expected = 8;
                if (result != null)
                {
                    List<SimpleData> ahList = result.OfType<SimpleData>().ToList();
                    count = ahList.Count();
                }

                if (count == expected) validity = true;

                Assert.That(validity, Is.EqualTo(true)); // Use constraint model and correct order
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}