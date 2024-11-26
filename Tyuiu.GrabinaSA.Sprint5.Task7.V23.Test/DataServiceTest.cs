using Tyuiu.GrabinaSA.Sprint5.Task7.V23.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task7.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"D:/repos/Tyuiu.GrabinaSA.Sprint5/Tyuiu.GrabinaSA.Sprint5.Task5.V26/bin/Debug/net8.0/OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.IsTrue(fileExists);
        }
    }
}