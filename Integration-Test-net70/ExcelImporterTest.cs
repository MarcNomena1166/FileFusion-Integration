using Domain;
using FileFusion;
namespace Integration_Test_net70
{
    public class ExcelImporterTest
    {
        private SimpleData _simpleData { get; set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetDataFeomExcelTest()
        {
            try
            {
                List<string> escapeChar = new List<string> { "/", "(", ")", "."," " };

                string path = System.AppContext.BaseDirectory;
                string file = "Test.xlsx";

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
            catch(Exception ex)
            {
                Assert.Fail(ex.Message);
            }
          
          
        }
    }
}