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
    /// Основной класс программы
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Точка входа в программу
        /// </summary>
        /// <exception cref="FileNotFoundException">Ошибка отсутствия входного файла</exception>
        /// <exception cref="ArgumentException">Ошибка отсутствия корректных данных</exception>
        /// <exception cref="IOException">Ошибка открытия файла</exception>
        /// <exception cref="UnauthorizedAccessException">Ошибка с записью в файл</exception>
        /// <exception cref="OverflowException">Ошибка с переполнением памяти</exception>
        public static void Main()
        {
            ConsoleKeyInfo exitKey;
            do
            {
                Console.Clear();
                Console.WriteLine($"Начато выполнение программы. Номер сессии: {Config.ReadConfig()}");
                try
                {
                    string fileData = FileUtils.ReadData("input.txt");
                    int[][] numbers = DataUtils.ParseData(fileData);
                    if (!DataUtils.ValidateData(numbers))
                    {
                        throw new ArgumentException();
                    }

                    DataUtils.ProcessData(numbers);
                    Console.WriteLine("Для перезапуска нажмите любую клавишу, Escape для выхода....");
                }
                catch (FileNotFoundException)
                {
                    HandleException("Входной Файл на диске отсутствует");
                }
                catch (ArgumentException)
                {
                    HandleException("Корректных данных в файле нет");
                }
                catch (IOException)
                {
                    HandleException("Проблемы с открытием файла");
                }
                catch (UnauthorizedAccessException)
                {
                    HandleException("Проблемы с записью данных в файл");
                }
                catch
                {
                    HandleException("Проблема с обработкой данных");
                }

                exitKey = Console.ReadKey();
                Console.CursorLeft = 0;
            } while (exitKey.Key != ConsoleKey.Escape);
        }

        /// <summary>
        /// Вывод информации об ошибке с предложением перезапустить программу
        /// </summary>
        /// <param name="errorMessage">Сообщение об ошибке</param>
        private static void HandleException(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            Console.WriteLine("Нажмите клавишу Escape для выхода или другую для перезапуска....");
        }
    }
}