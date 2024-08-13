namespace PrekshyaMaui.Views;

public partial class InputContentView : ContentView
{
	public static readonly BindableProperty FirstNameProperty = BindableProperty.Create(nameof(FirstName), typeof(string), typeof(InputContentView), string.Empty);

	public string FirstName
	{
		get => (string)GetValue(FirstNameProperty);
		set => SetValue(FirstNameProperty, value);
	}

    public static readonly BindableProperty LastNameProperty = BindableProperty.Create(nameof(LastName), typeof(string), typeof(InputContentView), string.Empty);

    public string LastName
    {
        get => (string)GetValue(FirstNameProperty);
        set => SetValue(FirstNameProperty, value);
    }
    public InputContentView()
	{
		InitializeComponent();
	}
}
