using System;

namespace Lib_13
{
    public class Classpr2
    {
       /// <summary>
       /// ������� ��� ������������ ������������ ���� ����� ������� ������ 2
       /// </summary>
       /// <param name="mas">������</param>
       /// <returns>������������</returns>
        public static int ProizvLb(int[] mas)
        {
            int pr = 1;
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
