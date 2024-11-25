using Tyuiu.GrabinaSA.Sprint5.Task0.V12.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task0.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = ds.SaveToFileTextData(3);
            bool fileExists = File.Exists(path);

            Assert.IsTrue(fileExists, "Ôàéë íå áûë ñîçäàí");


            string content = File.ReadAllText(path);
            double expected = Math.Round(Math.Pow(3, 3) / (2 * Math.Pow((3 + 5), 2)), 3);
            Assert.AreEqual(expected.ToString(), content, "Ñîäåðæèìîå ôàéëà íåêîððåêòíî");
        }
    }
}