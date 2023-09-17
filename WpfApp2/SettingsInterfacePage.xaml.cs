using System.Windows;

namespace WpfApp2
{
    public partial class SettingsInterfacePage : Window
    {
        public SettingsInterfacePage()
        {
            InitializeComponent();
        }

        private void OnBackClicked(object sender, System.Windows.RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
