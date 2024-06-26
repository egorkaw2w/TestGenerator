﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Window
    {
        TestTableAdapter Test = new TestTableAdapter();
        TestViewTableAdapter test = new TestViewTableAdapter();
        RightAnswersTableAdapter rightAnswers = new RightAnswersTableAdapter();
        public SecondPage()
        {
            InitializeComponent();
            vivod();
            RightAnswBox.ItemsSource = rightAnswers.GetData();
            RightAnswBox.DisplayMemberPath = "RightAnswer";
        }
        private void DataGridTestView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (DataGridTestView.SelectedItem != null)
                {
                    NameField.Text = ((DataGridTestView.SelectedItem as DataRowView).Row[1]).ToString();
                    DescField.Text = ((DataGridTestView.SelectedItem as DataRowView).Row[2]).ToString();
                    FirstAnswField.Text = ((DataGridTestView.SelectedItem as DataRowView).Row[3]).ToString();
                    SecondAnswField.Text = ((DataGridTestView.SelectedItem as DataRowView).Row[4]).ToString();
                    ThirdAnswField.Text = ((DataGridTestView.SelectedItem as DataRowView).Row[5]).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Успешное удаление");
            }
        }



        private void RightAnswBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        private void CreateNewTestBut_Click(object sender, RoutedEventArgs e)
        {
            object selected = (RightAnswBox.SelectedItem as DataRowView).Row[0];
            Test.Insert(NameField.Text, DescField.Text, FirstAnswField.Text, SecondAnswField.Text, ThirdAnswField.Text, Convert.ToInt32(selected));
            NameField.Text = "";
            DescField.Text = "";
            FirstAnswField.Text = "";
            SecondAnswField.Text = "";
            ThirdAnswField.Text = "";
            vivod();
        }

        private void Deleter_Click(object sender, RoutedEventArgs e)
        {
            object id = (DataGridTestView.SelectedItem as DataRowView).Row[0];
            Test.DeleteQuery(id.ToString());
            vivod();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        private void Updater_Click(object sender, RoutedEventArgs e)
        {
            object selected = (RightAnswBox.SelectedItem as DataRowView).Row[0];
            object id = (DataGridTestView.SelectedItem as DataRowView).Row[0];
            Test.UpdateQuery(NameField.Text, DescField.Text, FirstAnswField.Text, SecondAnswField.Text, ThirdAnswField.Text, Convert.ToInt32(selected),(int)(id));
            vivod();
        }

        private void vivod()
        {
            DataGridTestView.Columns[0].Visibility = Visibility.Hidden;
            DataGridTestView.ItemsSource = test.GetData();
            DataGridTestView.Columns[0].Visibility = Visibility.Hidden;
        }
    }
}
