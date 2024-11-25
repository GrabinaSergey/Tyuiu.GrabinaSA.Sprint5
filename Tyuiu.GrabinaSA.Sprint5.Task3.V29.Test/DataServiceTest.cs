using Tyuiu.GrabinaSA.Sprint5.Task3.V29.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:\repos\Tyuiu.GrabinaSA.Sprint5\Tyuiu.GrabinaSA.Sprint5.Task3.V29\bin\Debug\OutPutFileTask3.bin";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}