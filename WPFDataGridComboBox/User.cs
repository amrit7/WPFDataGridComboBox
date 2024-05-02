using CommunityToolkit.Mvvm.ComponentModel;

namespace WPFDataGridComboBox;

public partial class User: ObservableObject
{
    [ObservableProperty]
    private string _userName;

    [ObservableProperty]
    private string _password;

    [ObservableProperty]
    private string _email;

    [ObservableProperty]
    private string _firstName;

    [ObservableProperty]
    private string _lastName;

    [ObservableProperty]
    private string _food;
}

