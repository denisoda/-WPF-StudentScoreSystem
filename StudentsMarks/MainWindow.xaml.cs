using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Documents;

namespace StudentsMarks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Database.ListHandle LH = ListFormat;

        private static List<string> ListFormat(object rdr, List<string> L)
        {

            L.Add($"IM: {rdr} Name: {rdr} {rdr} Average Score: {rdr}");

            return L;
        }


        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ShowAll(object sender, RoutedEventArgs e)
        {   
            MainBox.Clear();


            foreach (var I in Database.StudentsReturn("SELECT * FROM Names", LH))
            {
                MainBox.AppendText($"{I}\n");
            }

        }

        private void ScoreSort_Click(object sender, RoutedEventArgs e)
        {
            MainBox.Clear();

            //DbComand Command = comand => "SELECT * FROM Names ORDER BY AverageScore desc";
            //foreach (var I in Database.StudentsReturn(Command))
            //{
            //    MainBox.AppendText($"{I}\n");
            //}
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            MainBox.Clear();

            //foreach (var I in Database.StudentsReturn("SELECT * FROM Names ORDER BY AverageScore"))
            //{
            //    MainBox.AppendText($"{I}\n");
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainBox.Clear();

            //foreach (var I in Database.StudentsReturn("SELECT * FROM Names ORDER BY ID"))
            //{
            //    MainBox.AppendText($"{I}\n");
            //}
        }
    }
}
