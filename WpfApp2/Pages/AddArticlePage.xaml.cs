using System.Windows;
using System.Windows.Controls;
using WpfApp2.Models;

namespace WpfApp2.Pages
{
    public partial class AddArticlePage : Page
    {
        public AddArticlePage()
        {
            InitializeComponent();
        }

        private void OnAddArticleClicked(object sender, RoutedEventArgs e)
        {
            Article newArticle = new Article(TitleTextBox.Text, ContentTextBox.Text, "CurrentUserName"); 
            ArticlesListPage.Articles.Add(newArticle); 

            MessageBox.Show("Статья добавлена!");
        }
    }
}
