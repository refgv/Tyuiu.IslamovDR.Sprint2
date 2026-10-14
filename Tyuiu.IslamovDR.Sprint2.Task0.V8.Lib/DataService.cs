using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IslamovDR.Sprint2.Task0.V8.Lib
{
    public class DataService : ISprint2Task0V8
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x < y;   // True  (185 < 251)
            res[1] = x == y;  // False (185 == 251)
            res[2] = x != y;  // True  (185 != 251)
            res[3] = x > y;   // False (185 > 251)
            res[4] = x <= y;  // True  (185 <= 251)
            res[5] = x >= y;  // False (185 >= 251)

            return res;
        }
    }
}