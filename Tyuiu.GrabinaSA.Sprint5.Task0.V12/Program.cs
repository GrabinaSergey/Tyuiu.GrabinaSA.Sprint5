using Tyuiu.GrabinaSA.Sprint5.Task0.V12.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task0.V12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                  *");
            Console.WriteLine("*****************************************************");

            Console.WriteLine("x: " + x);

            string filePath = ds.SaveToFileTextData(x);
            string result = File.ReadAllText(filePath);

            Console.WriteLine("*****************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                        *");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("Файл: " + filePath);
            Console.WriteLine("Создан!");
            Console.WriteLine("Результат вычисления y: " + result);
        }
    }
}
