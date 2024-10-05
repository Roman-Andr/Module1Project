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
    /// Класс работы с файлами
    /// </summary>
    public static class FileUtils
    {
        /// <summary>
        /// Чтение данных из файла в рабочей папке
        /// </summary>
        /// <param name="fileName">Название файла в папке</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException">Ошибка отсутствия файла</exception>
        public static string ReadData(string fileName)
        {
            string path = CombinePath(fileName);
            return File.Exists(path) ? File.ReadAllText(path) : throw new FileNotFoundException();
        }

        /// <summary>
        /// Формирование полного пути к файлам в рабочей папке WorkingFiles
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <returns>Полный путь до файла</returns>
        public static string CombinePath(string fileName)
        {
            string projectDir = Directory.GetParent(Environment.CurrentDirectory)!.Parent!.Parent!.Parent!.FullName;
            return Path.Combine(projectDir, "WorkingFiles", fileName);
        }

        /// <summary>
        /// Запись данных в файл в рабочей папке
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <param name="value">Данные для записи</param>
        public static void WriteData(string fileName, string value)
        {
            File.WriteAllText(CombinePath(fileName), value);
        }
    }
}