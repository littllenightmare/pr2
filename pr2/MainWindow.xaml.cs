using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_13;

namespace pr2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a = 0;//число для проверки целого числа
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddClick(object sender, RoutedEventArgs e)//кнопка добавления числа
        {
            
           if(Int32.TryParse( tbCh.Text, out a )== true)//преобразовываем текстбокс в целое число и если норм, добавляем в лб
            {
              listbox.Items.Add(a);
            }
            tbCh.Text = "";
            tbRez.Text = "";
        }

        private void DelAllClick(object sender, RoutedEventArgs e)//очищаем список
        {
            listbox.Items.Clear();
            tbRez.Text = "";
        }

        private void RandomCLick(object sender, RoutedEventArgs e)//рандомно заполняем список
        {
            Random random = new Random();
            if (Int32.TryParse(tbCh.Text, out a) == true)//снова преобразовываем, но чтобы понять, сколько чисел будет
            {
                int n = Convert.ToInt32(tbCh.Text);//вот то самое число, это количество рандомных чисел
                for (int i = 0; i < n; i++)//обычный цикл, заполняем лб рандомными цифрами
                {
                    a = random.Next(10);
                    listbox.Items.Add(a);
                }
            }
            tbRez.Text = "";
        }

        private void DelOneClick(object sender, RoutedEventArgs e)//удаляем один выделенный объект
        {
            if (Convert.ToInt32(listbox.SelectedItems.Count) != 0)
                listbox.Items.RemoveAt(listbox.SelectedIndex);//через выделенный элемент(индекс)
            tbRez.Text= "";
        }

        private void ExitClick(object sender, RoutedEventArgs e)//кнопка выхода из программы
        {
            this.Close();
        }

        private void InfoClick(object sender, RoutedEventArgs e)//кнопка информации
        {
            MessageBox.Show("Выполнено Кульковой Ангелиной ИСП-31.\r\n Практическая 2.\r\nВвести n целых чисел.\r\n Найти произведение чисел > 2. Результат вывести на экран.");

        }

        private void RasClick(object sender, RoutedEventArgs e)//кнопка рассчёта
        {
            int[] mas = new Int32[listbox.Items.Count];//создаём массив, в который запихнём листбокс
            int pr=0;
            for(int j=0; j<listbox.Items.Count; j++)//цикл для записи листбокса в массив
            {
                mas[j] = Convert.ToInt32(listbox.Items[j]);
            }
            Classpr2.ProizvLb(mas, out pr);//вызываем функцию из библиотеки
            if(listbox.Items.Count!=0)
            tbRez.Text = Convert.ToString(pr);//выводим в текстбокс результат
        }
    }
}
