using WpfApp2.Models;
using System;
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
using WpfApp2.Models;

namespace WpfApp2.Pages
{
    public partial class UsersPage : Page
    {
        List<User> users = new List<User>();
        public UsersPage()
        {
            InitializeComponent();
            User user = new User();
            user.Id = "";
            user.Name = "";
            user.Password = "";
            users.Add(user);

            users.Add(new User() { Id = "1", Name = "Ilnaz", Password = "iamirhanov@fix.ru" });
            users.Add(new User("2", "Petuh", "kopylownikita2004@odnoklasniki.ru"));

            DGUsers.ItemsSource = users.ToList();
        }
    }
}
