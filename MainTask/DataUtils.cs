/*
 * Дисциплина: "Программирование"
 * Группа: БПИ244
 * Студент: Андрусевич Роман Дмитриевич
 * Дата: 01.10.2024
 * Вариант: 9
 */
using static MainTask.Formatter;
using static MainTask.Operations;

namespace MainTask
{
    /// <summary>
    /// Класс работы с данными
    /// </summary>
    public static class DataUtils
    {
        /// <summary>
        /// Обработка данных
        /// </summary>
        /// <param name="numbers">Входной массив числовых данных</param>
        public static void ProcessData(int[] numbers)
        {
            string data = $"{FormatValue(Product(numbers))};{Sum(numbers)}";
            FileUtils.WriteData("output.txt", data);
        }

        /// <summary>
        /// Преобразование данных в числовой вид
        /// </summary>
        /// <param name="row">Текстовое представление данных</param>
        /// <returns>Числовой массив данных</returns>
        public static int[] ParseData(string row)
        {
            string[] items = row.Split(Environment.NewLine)[0].Split(';');
            return ParseArray(items);
        }

        /// <summary>
        /// Преобразование чисел из тексового в числовое представление
        /// </summary>
        /// <param name="items">Массив чисел в текстовом виде</param>
        /// <returns>Массив чисел</returns>
        private static int[] ParseArray(string[] items)
        {
            int[] result = new int[items.Length];
            int count = 0;
            foreach (string item in items)
            {
                if (!int.TryParse(item, out int temp) || temp == 0)
                {
                    continue;
                }

                result[count] = temp;
                count++;
            }

            Array.Resize(ref result, count);
            return result;
        }

        /// <summary>
        /// Проверка на присутствие данных
        /// </summary>
        /// <param name="data">Массив данных</param>
        /// <returns>Возвращает правду, если в массиве имеется хоть один набор данных</returns>
        public static bool ValidateData(int[] data)
        {
            return data.Length != 0;
        }
    }
}