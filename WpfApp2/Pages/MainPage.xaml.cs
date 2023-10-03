using System.Windows.Controls;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ListItems_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            ItemsListPage itemsListPage = new ItemsListPage();
            itemsListPage.Show();
        }
    }
}
