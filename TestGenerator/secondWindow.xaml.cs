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
using System.Windows.Shapes;
using TestGenerator.TestsTableAdapters;

namespace TestGenerator
{
    /// <summary>
    /// Логика взаимодействия для secondWindow.xaml
    /// </summary>
    public partial class secondWindow : Window
    {
        int counter = 0;
        TestTableAdapter Test = new TestTableAdapter();
        RightAnswersTableAdapter rightAnswers = new RightAnswersTableAdapter();
        public secondWindow( bool check)
        {
            InitializeComponent();
            if (!check)
            {
                TestEdit.IsEnabled = false;
            }
            PageFrame2.Content = new AuthorizatedUser();
            var i = Test.GetData().ToList();
        }

        private void PageFrame2_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
/*            MessageBox.Show(Test.GetData().ToList().Count().ToString());
*/            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        private void TestEdit_Click(object sender, RoutedEventArgs e)
        {

            PageFrame2.Content = new AuthorizatedUser();


        }

        private void DoTest_Click(object sender, RoutedEventArgs e)
        {
            PageFrame2.Content = new TestEnjoyer();
        }
    }

}

