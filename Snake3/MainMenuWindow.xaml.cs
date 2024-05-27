using System.Windows;

namespace Snake3
{
    public partial class MainMenuWindow : Window
    {
        private string selectedDifficulty = "Середній"; 

        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            if (settingsWindow.ShowDialog() == true)
            {
                selectedDifficulty = settingsWindow.SelectedDifficulty;
                MainWindow mainWindow = new MainWindow(selectedDifficulty);
                this.Close();
                mainWindow.Show();
            }
        }

        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            SettingsWindow settingsWindow = new SettingsWindow();
            if (settingsWindow.ShowDialog() == true)
            {
                selectedDifficulty = settingsWindow.SelectedDifficulty;
            }
        }
    }
}
