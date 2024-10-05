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
    /// Класс работы с конфигом
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// Чтение данных из конфига, при отсутствии создаем
        /// </summary>
        /// <returns>Число-счетчик из конфига</returns>
        public static int ReadConfig()
        {
            string path = FileUtils.CombinePath("config.txt");
            if (!File.Exists(path))
            {
                ResetConfig();
            }

            string data = FileUtils.ReadData("config.txt");
            if (!int.TryParse(data, out int result))
            {
                ResetConfig();
            }
            return result;
        }

        /// <summary>
        /// Запись данных в конфиг
        /// </summary>
        /// <param name="value">Число-счетчик для записи</param>
        public static void WriteConfig(int value)
        {
            FileUtils.WriteData("config.txt", $"{value}");
        }

        /// <summary>
        /// Перезапись конфига
        /// </summary>
        private static void ResetConfig()
        {
            FileUtils.WriteData("config.txt", "0");
        }
    }
}