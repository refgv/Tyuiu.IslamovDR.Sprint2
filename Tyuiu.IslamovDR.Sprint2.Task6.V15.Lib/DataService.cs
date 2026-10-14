using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.IslamovDR.Sprint2.Task6.V15.Lib
{
    public class DataService : ISprint2Task6V15
    {
        public string FindDayName(int k)
        {
            int day = ((k - 1) % 7) + 1;

            return day switch
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                7 => "воскресенье",
                _ => "ошибка"
            };
        }
    }
}