namespace Tyuiu.IslamovDR.Sprint2.Review0.V19.Lib
{
    public class DataService
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверка попадания точки в закрашенную область пересечения окружностей с графика
            bool condition1 = (Math.Pow(x - x * 3, 2) + Math.Pow(y - y * 3, 2) <= Math.Pow(1.8, 2));
            bool condition2 = (Math.Pow(x - 1.4, 2) + Math.Pow(y + 1, 2) <= Math.Pow(-1.9, 2));
            bool condition3 = (Math.Pow(x - 1.2, 2) + Math.Pow(y + 2.8, 2) <= Math.Pow(2.5, 2));

            // Точка должна находиться в пересечении областей (фиолетовые зоны на графике)
            bool res = (condition1 && condition3) || (condition2 && !condition3 && !condition1);

            return res;
        }
    }
}