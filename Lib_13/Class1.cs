using System;

namespace Lib_13
{
    public class Classpr2
    {
        /// <summary>
        /// Функция для рассчёта произведения всех чисел больше 2 из массива
        /// </summary>
        /// <param name="mas">массив</param>
        /// <param name="pr">произведение</param>
        /// <returns>произведение всех чисел больше 2</returns>
        public static int ProizvLb(int[] mas, out int pr)
        {
            pr = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] > 2)
                {
                    pr = pr * mas[i];
                }
            }

            return pr;
        }
    }
}
