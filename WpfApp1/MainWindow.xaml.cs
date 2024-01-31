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

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        private List<int> numbers = new List<int>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(inputTextBox.Text, out int input))
            {
                numbers.Add(input);
                numbersTextBlock.Text = $"Megadott számok: {string.Join(", ", numbers)}";
                inputTextBox.Clear();
            }
        }

        private void MinimumButton_Click(object sender, RoutedEventArgs e)
        {
            if (numbers.Count > 0)
            {
                int min = numbers.Min();
                MessageBox.Show($"Minimum: {min}");
            }
            else
            {
                MessageBox.Show("Nem adott meg számot.");
            }
        }

        private void MaximumButton_Click(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
