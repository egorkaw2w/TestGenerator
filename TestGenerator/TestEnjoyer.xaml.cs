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
        int selected = -1;

        public TestEnjoyer()
        {
            InitializeComponent();
            ShowQuest();


        }

        private void firstAnsw_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SecondAnsw_Click(object sender, RoutedEventArgs e)
        {
            ShowQuest();
        }

        private void ThirdAnsw_Click(object sender, RoutedEventArgs e)
        {
            ShowQuest();
            /*            if ()
                        {

                        }*/
        }
        private void ShowQuest()
        {
            selected++;
            var sel = Test.GetData()[selected];

            if (sel == null)
            {
                selected++;
            }
            else
            {
                QuestName.Text = sel.TestName.ToString();
                QuestDisc.Text = sel.TestDesc.ToString();
                firstAnsw.Content = sel.FirstAnsw.ToString();
                SecondAnsw.Content = sel.SecondAnsw.ToString();
                ThirdAnsw.Content = sel.ThirdAnsw.ToString();
            }

        }
    }
}
