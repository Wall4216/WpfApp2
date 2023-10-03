using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Models
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; } 

        public Article() { }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
    }
}



