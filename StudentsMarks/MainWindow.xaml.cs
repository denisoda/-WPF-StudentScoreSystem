using System.Windows;

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

        }

        private void ScoreSort_Click(object sender, RoutedEventArgs e)
        {
            MainBox.Clear();

            foreach (var I in Database.StudentsReturn("SELECT * FROM Names ORDER BY AverageScore desc"))
            {
                MainBox.AppendText($"{I}\n");
            }
        }

        private void k_Click(object sender, RoutedEventArgs e)
        {
            MainBox.Clear();

            foreach (var I in Database.StudentsReturn("SELECT * FROM Names ORDER BY AverageScore"))
            {
                MainBox.AppendText($"{I}\n");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainBox.Clear();

            foreach (var I in Database.StudentsReturn("SELECT * FROM Names ORDER BY ID"))
            {
                MainBox.AppendText($"{I}\n");
            }
        }
    }
}
