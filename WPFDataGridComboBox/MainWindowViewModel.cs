using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using static MaterialDesignThemes.Wpf.Theme.ToolBar;

namespace WPFDataGridComboBox;

public partial class MainWindowViewModel : ObservableObject
{
    private ObservableCollection<User> _users = new ObservableCollection<User>();

    public ObservableCollection<User> Users 
    {
        get
        {
            return _users;
        }
        set
        {
            if (_users != value)
            {
                _users = value;
            }
        }
    }

    public List<string> FirstNamesStringList { get; set; } = new List<string>();

    public List<User> FirstNamesUserList { get; set; } = new List<User>();

    public IEnumerable<string> Foods => new[] { "Burger", "Fries", "Shake", "Lettuce" };

    public MainWindowViewModel()
    {
        Users.Clear();

        for (int i = 0; i < 10; i++)
        {
            var item = new User();
            item.FirstName = "Joe" + i;
            item.LastName = "Blogs" + i;
            item.Email = "joe.blogs@test.com" + i;
            item.Password = "12345" + i;
            item.UserName = "JoeBlogs" + i;
            item.Food = "Fries";
            Users.Add(item);
        }

        GetUsers();
    }
    
    private void GetUsers()
    {
        FirstNamesStringList.Clear();

        foreach (var item in Users)
        {
            FirstNamesStringList.Add(item.FirstName);

            var item2 = new User();
            item2.FirstName = item.FirstName;
            item2.LastName = item.LastName;
            item2.Email = item.Email;
            item2.Password = item.Password;
            item2.UserName = item.UserName;
            item2.Food = item.Food;
            FirstNamesUserList.Add(item2);
        }
    }
}