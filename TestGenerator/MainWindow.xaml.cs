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

namespace TestGenerator
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

        private void DoTest_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateTest_Click(object sender, RoutedEventArgs e)
        {
            PassCheck.Visibility = Visibility.Visible;

        }

        private void PassCheck_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PassCheck.Text == "пароль")
            {
                secondWindow window = new secondWindow();
                window.Show();
                Close();
            }
        }
    }
}
