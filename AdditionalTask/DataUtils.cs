/*
 * Дисциплина: "Программирование"
 * Группа: БПИ244
 * Студент: Андрусевич Роман Дмитриевич
 * Дата: 01.10.2024
 * Вариант: 9
 */

using static AdditionalTask.Formatter;
using static AdditionalTask.Operations;

namespace AdditionalTask
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
        public static void ProcessData(int[][] numbers)
        {
            int counter = Config.ReadConfig() + 1;
            string data = "";
            foreach (int[] items in numbers)
            {
                data += $"{FormatValue(Product(items))};{Sum(items)}{Environment.NewLine}";
            }

            FileUtils.WriteData($"output-{counter}.txt", data);
            Config.WriteConfig(counter);
        }

        /// <summary>
        /// Преобразование данных в числовой вид
        /// </summary>
        /// <param name="data">Текстовое представление данных</param>
        /// <returns>Числовой массив данных</returns>
        public static int[][] ParseData(string data)
        {
            string[] rows = data.Split(Environment.NewLine);
            int[][] nums = new int[rows.Length][];
            int count = 0;
            for (int i = 0; i < rows.Length; i++)
            {
                string[] items = rows[i].Split(';');
                int[] temp = ParseArray(items);
                if (temp.Length == 0)
                {
                    continue;
                }

                nums[count] = temp;
                count++;
            }

            Array.Resize(ref nums, count);
            return nums;
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
        public static bool ValidateData(int[][] data)
        {
            return data.Length != 0;
        }
    }
}