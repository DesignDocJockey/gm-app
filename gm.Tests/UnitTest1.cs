using System;
using System.IO;
using System.Linq;
using System.Reflection;
using gm.Data.Repository;

using Xunit;

namespace gm.Tests
{
    public class RepositoryTests
    {
        [Fact]
        public void ItGetsDataFromACSVFile()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = Path.Combine(appPath, "MockData\\GM_Backend_Coding_Exercise_-_Sample_Data_Report.csv");
            var repo = new InMemoryCSVRepository(filePath);
            var records = repo.GetAllTimeSheets();
            Assert.True(records.Count() > 0);
        }
    }
}
