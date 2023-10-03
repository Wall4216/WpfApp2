using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }

        public User()
        {

        }

        public User(string id, string name, string password)
        {
            Id = id;
            Name = name;
            Password = password;
        }
    }
}
