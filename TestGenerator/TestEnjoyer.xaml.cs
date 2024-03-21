using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для TestEnjoyer.xaml
    /// </summary>
    public partial class TestEnjoyer : Page
    {
        TestTableAdapter Test = new TestTableAdapter();
        TestViewTableAdapter test = new TestViewTableAdapter();
        RightAnswersTableAdapter rightAnswers = new RightAnswersTableAdapter();

        public TestEnjoyer()
        {
            InitializeComponent();

            
        }

        private void firstAnsw_Click(object sender, RoutedEventArgs e)
        {
            

 /*           foreach(string i in elements)
            {
                
            }*/
        }

        private void SecondAnsw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ThirdAnsw_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
