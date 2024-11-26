using System.IO;
using Tyuiu.GrabinaSA.Sprint5.Task7.V23.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task7.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"D:/repos/Tyuiu.GrabinaSA.Sprint5Tyuiu.GrabinaSA.Sprint5.Task5.V26/bin/Debug/net8.0/OutPutFileTask1.txt";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Строка из файла:");
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.WriteLine($"Данные находятся в файле: {path}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.LoadDataAndSave(path);
            Console.WriteLine("Полученные данные находятся в файле:");
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
