/*
 * Дисциплина: "Программирование"
 * Группа: БПИ244
 * Студент: Андрусевич Роман Дмитриевич
 * Дата: 01.10.2024
 * Вариант: 9
 */

namespace MainTask
{
    /// <summary>
    /// Класс форматирования значений
    /// </summary>
    public static class Formatter
    {
        /// <summary>
        /// Форматирование вещественных чисел
        /// до определенной точности
        /// </summary>
        /// <param name="value">Входное значение</param>
        /// <returns></returns>
        public static string FormatValue(double value)
        {
            return $"{Math.Truncate(value * Math.Pow(10, 3)) / Math.Pow(10, 3):F3}".Replace(",", ".");
        }
    }
}