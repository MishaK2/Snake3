using System.Windows;

namespace Snake3
{
    public partial class SettingsWindow : Window
    {
        public string SelectedDifficulty { get; private set; } = "Середній";

        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, RoutedEventArgs e)
        {
            SelectedDifficulty = "Легкий";
            this.DialogResult = true;
            this.Close();
        }

        private void btnMedium_Click(object sender, RoutedEventArgs e)
        {
            SelectedDifficulty = "Середній";
            this.DialogResult = true;
            this.Close();
        }

        private void btnHard_Click(object sender, RoutedEventArgs e)
        {
            SelectedDifficulty = "Важкий";
            this.DialogResult = true;
            this.Close();
        }
    }
}
