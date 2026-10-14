using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IslamovDR.Sprint2.Task1.V8.Lib
{
    public class DataService : ISprint2Task1V8
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) & (c < d);   // True
            res[1] = (a > b) | (c > d);   // False
            res[2] = (a < b) && (c < d);  // True
            res[3] = (a > b) || (c > d);  // False
            res[4] = !(a < b);            // False
            res[5] = (a < b) ^ (c < d);   // False

            return res;
        }
    }
}