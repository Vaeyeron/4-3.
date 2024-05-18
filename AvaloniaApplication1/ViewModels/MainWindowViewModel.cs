using System.Collections.ObjectModel;
using AvaloniaApplication1.ViewModels;

namespace AvaloniaApplication1.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<BlogPost> BlogPosts { get; }
    public ObservableCollection<NewsItem> NewsItems { get; }

    public MainWindowViewModel()
    {
        BlogPosts = new ObservableCollection<BlogPost>
            {
                new BlogPost("Article 1", "Lorem ipsum dolor sit amet...", "avares://AvaloniaApplication1/Assets/avalonia-logo.ico"),
            };

        NewsItems = new ObservableCollection<NewsItem>
            {
                new NewsItem("Lorem ipsum dolor sit amet...", "Yesterday"),
                new NewsItem("Lorem ipsum dolor sit amet...", "1 week ago"),
            };
    }
}
