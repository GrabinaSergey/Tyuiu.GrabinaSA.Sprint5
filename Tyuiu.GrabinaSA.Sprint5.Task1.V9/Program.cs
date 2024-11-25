using Tyuiu.GrabinaSA.Sprint5.Task1.V9.Lib;
namespace Tyuiu.GrabinaSA.Sprint5.Task1.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                             *");
            Console.WriteLine("*         2                                                     *");
            Console.WriteLine("*               cos(x)                                          *");
            Console.WriteLine("* y = sin(x) + -------- - 1,5 * x                               *");
            Console.WriteLine("*                  2                                            *");
            Console.WriteLine("*****************************************************************");

            int start = -5;
            int end = 5;

            Console.WriteLine($"* Отрезок: [{start};{end}]                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                    *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine($"* Файл: {ds.SaveToFileTextData(start, end)} ");
            Console.WriteLine($"* Создан!                                                             *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();
        }
    }
}
