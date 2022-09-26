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
using lib_13;

namespace Prakt1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Random_Click(object sender, RoutedEventArgs e) //Создание массива
        {
            Itog.Clear();
            Itog.Text = Class1.Vichisl(); //Вывод генерируемого числа и полученного из функции значения
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Itog.Clear(); //Очистка
        }

        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); //Закрытие 
        }

        private void Spravka_Click(object sender, RoutedEventArgs e) //Справка
        {
            MessageBox.Show("Калитин С.А. ИСП-31.Генерировать случайные числа Х, распределенные в диапазоне от -5 до 5 и" +
                "вычислять для чисел > 0 кор(x), а для чисел < 0 квадрат(x),Вычисления прекратить, когда подряд появится два" +
                "одинаковых случайных числа. На экран необходимо выводить сгенерированное число и результат расчета функции на" +
                "разных строках");
        }
    }
}
