using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication1
{
    public class BlogPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImagePath { get; set; }

        public BlogPost(string title, string content, string imagePath)
        {
            Title = title;
            Content = content;
            ImagePath = imagePath;
        }
    }

    public class NewsItem
    {
        public string Content { get; set; }
        public string Date { get; set; }

        public NewsItem(string content, string date)
        {
            Content = content;
            Date = date;
        }
    }
}
