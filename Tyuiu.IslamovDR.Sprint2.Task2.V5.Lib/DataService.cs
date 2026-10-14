using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IslamovDR.Sprint2.Task2.V5.Lib
{
    public class DataService : ISprint2Task2V5
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res = false;

            if ((y >= 3 && y <= 4 && x >= 2 && x <= 4) ||
                (y == 3 && x == 9) ||
                (y >= 3 && y <= 5 && x >= 11 && x <= 13) ||
                (y >= 4 && y <= 8 && x >= 5 && x <= 11) ||
                (y >= 6 && y <= 8 && x >= 12 && x <= 13) ||
                (y >= 9 && y <= 11 && x >= 5 && x <= 8) ||
                (y == 11 && x >= 2 && x <= 4) ||
                (y == 12 && x >= 5 && x <= 10))
            {
                res = true;
            }

            return res;
        }
    }
}