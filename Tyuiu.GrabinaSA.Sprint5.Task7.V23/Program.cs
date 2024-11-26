using System.IO;
using Tyuiu.GrabinaSA.Sprint5.Task7.V23.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Path.GetTempFileName();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Строка из файла:");
            using (StreamReader reader = new StreamReader(Path.GetTempFileName()))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine($"Данные находятся в файле: {Path.GetTempFileName()}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(Path.GetTempFileName());
            Console.WriteLine("Полученные данные находятся в файле:");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
