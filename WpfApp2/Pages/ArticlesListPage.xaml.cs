using System.Collections.Generic;
using System.Windows.Controls;
using WpfApp2.Models;

namespace WpfApp2.Pages
{
    public partial class ArticlesListPage : Page
    {
        public static List<Article> Articles = new List<Article>();

        public ArticlesListPage()
        {
            InitializeComponent();
            ArticlesListView.ItemsSource = Articles;
        }
    }
}
