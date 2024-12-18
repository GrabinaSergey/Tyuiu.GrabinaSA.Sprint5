﻿using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.GrabinaSA.Sprint5.Task4.V23.Lib
{
    public class DataService : ISprint5Task4V23
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string strX1 = strX.Replace(".", ",");
            double res = Math.Pow(Convert.ToDouble(strX1), -3) + 2 + Math.Cos(Convert.ToDouble(strX1));
            res = Math.Round(res, 3);
            return res;
        }
    }
}
