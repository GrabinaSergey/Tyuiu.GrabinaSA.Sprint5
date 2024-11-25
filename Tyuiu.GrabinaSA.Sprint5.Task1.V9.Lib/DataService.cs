using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GrabinaSA.Sprint5.Task1.V9.Lib
{
    public class DataService : ISprint5Task1V9
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist) { File.Delete(path); }

            for (double x = startValue; x <= stopValue; x++)
            {
                double result = Math.Sin(x) + ((Math.Cos(2 * x)) / 2) - 1.5 * x;
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    result = 0;
                }
                result = Math.Round(result, 2);
                File.AppendAllText(path, $"{result}\n");
                Console.Write($"{result}\n");
            }
            return path;
        }
    }
}
