using System.Windows.Controls;

namespace WpfApp2
{
    public partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void OnBackClicked(object sender, System.Windows.RoutedEventArgs e)
        {
            if (NavigationService != null)
            {
                NavigationService.GoBack();
            }
        }
        private void OnInterfaceSettingsClicked(object sender, System.Windows.RoutedEventArgs e)
        {
            SettingsInterfacePage interfaceSettings = new SettingsInterfacePage();
            interfaceSettings.Show();
        }
    }
}
