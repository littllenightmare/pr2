using System;

namespace Lib_13
{
    public class Classpr2
    {
        /// <summary>
        /// ������� ��� �������� ������������ ���� ����� ������ 2 �� �������
        /// </summary>
        /// <param name="mas">������</param>
        /// <param name="pr">������������</param>
        /// <returns>������������ ���� ����� ������ 2</returns>
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
