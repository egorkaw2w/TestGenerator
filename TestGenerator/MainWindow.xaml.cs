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
using TestGenerator.TestsTableAdapters;

namespace TestGenerator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestTableAdapter Test = new TestTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DoTest_Click(object sender, RoutedEventArgs e)
        {
            secondWindow window = new secondWindow(false);
            window.Show();
            if (Test.GetData().ToList().Count != 0)
            {
                window.PageFrame2.Content = new TestEnjoyer();
                Close();
            }
            else
            {
                window.PageFrame2.Content = new NotFound();
                Close();
            }
      
        }

        private void CreateTest_Click(object sender, RoutedEventArgs e)
        {
            PassCheck.Visibility = Visibility.Visible;

        }

        private void PassCheck_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (PassCheck.Text == "пароль")
            {
                secondWindow window = new secondWindow(true);
                window.Show();
                Close();
            }
        }
    }
}
