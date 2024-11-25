using Tyuiu.GrabinaSA.Sprint5.Task1.V9.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\repos\Tyuiu.GrabinaSA.Sprint5\Tyuiu.GrabinaSA.Sprint5.Task1.V9\bin\Debug\OutPutFileTask1.txt";

            FileInfo file = new FileInfo(path);
            bool fileExists = file.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}