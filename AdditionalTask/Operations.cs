/*
 * Дисциплина: "Программирование"
 * Группа: БПИ244
 * Студент: Андрусевич Роман Дмитриевич
 * Дата: 01.10.2024
 * Вариант: 9
 */

namespace AdditionalTask
{
    /// <summary>
    /// Класс необходимых операций над массивом
    /// </summary>
    public static class Operations
    {
        /// <summary>
        /// Произведение обратных значений каждого третьего элемента массива
        /// </summary>
        /// <param name="items">Входной массив чисел</param>
        /// <returns>Резульат произведения</returns>
        public static double Product(int[] items)
        {
            double result = 1;
            for (int i = 0; i < items.Length; i += 3)
            {
                if (i < items.Length)
                {
                    result *= 1.0 / items[i];
                }
            }

            return result;
        }

        /// <summary>
        /// Сумма нечетных элементов массива
        /// </summary>
        /// <param name="items">Входной массив чисел</param>
        /// <returns>Результат суммирования</returns>
        public static int Sum(int[] items)
        {
            int result = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (i % 2 == 1)
                {
                    result += items[i];
                }
            }

            return result;
        }
    }
}