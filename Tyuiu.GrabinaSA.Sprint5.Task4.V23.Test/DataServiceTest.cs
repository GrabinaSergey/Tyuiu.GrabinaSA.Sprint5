using Tyuiu.GrabinaSA.Sprint5.Task4.V23.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task4.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"D:\repos\Tyuiu.GrabinaSA.Sprint5\Tyuiu.GrabinaSA.Sprint5.Task1.V9\bin\Debug\InPutDataFileTask4V23.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}