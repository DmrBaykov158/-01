using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_1;

namespace Практическая_байков_1
{
    
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent(); // Инициализация компонентов из XAML
            

        }

       
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int K = int.Parse(KTextBox.Text); // Преобразование введенного значения в целое число

                (int[] numbers, int sum, int count) = CalculationModule.CalculateSum(K);

                // Отображение результатов в TextBox
                ResultTextBox.Text = $"Сгенерированные числа: {string.Join(", ", numbers.Take(count))}\n" +
                                     $"Сумма: {sum}\n" +
                                     $"Количество чисел: {count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        
        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ФИО разработчика: Байков Дмитрий\n" +
                            "Номер работы: 1\n" +
                            "Задание: Вычислить сумму целых случайных чисел, распределенных в диапазоне от 2 до 10, пока эта сумма не превышает некоторого числа K. Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        
        private void Close(object sender, RoutedEventArgs e)
        {
            Close(); // Закрытие окна
        }
    }
}