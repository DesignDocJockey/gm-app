using System;
using System.IO;
using System.Reflection;
using gm.Data.Repository;

using Xunit;

namespace gm.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var appPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var filePath = Path.Combine(appPath, "MockData\\GM_Backend_Coding_Exercise_-_Sample_Data_Report.csv");
            var repo = new InMemoryCSVRepository(filePath);
        }
    }
}
