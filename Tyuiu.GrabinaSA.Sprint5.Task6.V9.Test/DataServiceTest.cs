using Tyuiu.GrabinaSA.Sprint5.Task6.V9.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"D:\repos\Tyuiu.GrabinaSA.Sprint5\Tyuiu.GrabinaSA.Sprint5.Task6.V9\bin\Debug\InPutDataFileTask6V9.txt";

            var res = ds.LoadFromDataFile(path);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string path = @"D:\repos\Tyuiu.GrabinaSA.Sprint5\Tyuiu.GrabinaSA.Sprint5.Task6.V9\bin\Debug\InPutDataFileTask6V9.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}