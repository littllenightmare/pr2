﻿namespace LibMas
{
    public class Massiv
    {
        /// <summary>
        /// Заполнение массива рандомом
        /// </summary>
        /// <param name="mas">сам массив</param>
        /// <param name="column">количество ячеек</param>
        /// <param name="randMax">максимальное число для рандома</param>
        public static void InitMas(out int[] mas, int column, int randMax)
        {
            Random random = new Random();
            mas = new int[column];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(randMax);
            }
        }
        /// <summary>
        /// Суммирование элементов массива
        /// </summary>
        /// <param name="mas">сам массив</param>
        /// <returns>сумму всех элементов массива</returns>
        public static int SumMas(int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i];
            }
            return sum;
        }
        /// <summary>
        /// Функция для записи массива в файл
        /// </summary>
        /// <param name="mas">сам массив</param>
        /// <param name="filename">имя файла</param>
        public static void SaveMas(int[] mas)
        {
            StreamWriter sw = new StreamWriter("Массив.txt");
            sw.WriteLine(mas.Length);
            for (int i = 0; i < mas.Length; i++)
            {
                sw.WriteLine(mas[i]);
            }
            sw.Close();
        }
        /// <summary>
        /// Функция для чтения массива из файла
        /// </summary>
        /// <param name="mas">сам массив</param>
        /// <param name="filename">имя файла</param>
        public static void OpenMas(out int[] mas)
        {
            StreamReader sr = new StreamReader("Массив.txt");
            int len = Convert.ToInt32(sr.ReadLine());
            mas = new int[len];
            for (int i = 0; i < len; i++)
            {
                mas[i] = Convert.ToInt32(sr.ReadLine());
            }
            sr.Close();
        }
    }
}