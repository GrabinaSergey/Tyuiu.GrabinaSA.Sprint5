using Tyuiu.GrabinaSA.Sprint5.Task7.V23.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(Path.GetTempFileName());
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}