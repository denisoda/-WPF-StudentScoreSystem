﻿using System;
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

namespace StudentsMarks
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void ShowAll(object sender, RoutedEventArgs e)
        {   
            MainBox.Clear();

            foreach (var I in Database.StudentsReturn())
            {
                MainBox.AppendText($"{I}\n");
            }

            BShowAll.IsEnabled = false;
        }

        private void ScoreSort_Click(object sender, RoutedEventArgs e)
        {
            MainBox.Clear();


            foreach (var I in Database.StudentsReturn("SELECT * FROM Names ORDER BY "))
            {

            }
        }   
    }
}
