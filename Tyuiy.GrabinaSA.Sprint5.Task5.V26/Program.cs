using Tyuiy.GrabinaSA.Sprint5.Task5.V26.Lib;
namespace Tyuiy.GrabinaSA.Sprint5.Task5.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask5.txt");
            // поиск файла OutPutFileTask5.txt
            Console.WriteLine("Данные находяться в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");


            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(" Разница суммы всех элементов: " + res);
            Console.ReadLine();

        }
    }
}
