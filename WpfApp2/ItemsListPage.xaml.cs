using System.Windows;

namespace WpfApp2
{
    public partial class ItemsListPage : Window
    {
        public ItemsListPage()
        {
            InitializeComponent();
            LoadItems();
        }

        private void LoadItems()
        {
            itemsListBox.Items.Add("Товар 1");
            itemsListBox.Items.Add("Товар 2");
            itemsListBox.Items.Add("Товар 3");
        }
    }
}
