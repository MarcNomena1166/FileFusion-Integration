using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

                List<object>? result = FileFusion.FileFusion.Extract<SimpleData>(file, path, escapeChar, 3);
                int count = 0;
                bool validity = false;
                const int expected = 8;
                if (result != null)
                {
                    List<SimpleData> ahList = result.OfType<SimpleData>().ToList();
                    count = ahList.Count();
                }

                if (count == expected) validity = true;

                Assert.AreEqual(validity, true);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }


        }
    }
}
