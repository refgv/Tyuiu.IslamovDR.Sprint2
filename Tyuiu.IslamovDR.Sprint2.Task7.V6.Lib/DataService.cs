using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IslamovDR.Sprint2.Task7.V6.Lib
{
    public class DataService : ISprint2Task7V6
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res = (x * x + y * y <= 4) && (x * x + y * y >= 1) && (y >= 0);
            return res;
        }
    }
}