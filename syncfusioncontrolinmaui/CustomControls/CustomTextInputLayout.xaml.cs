

namespace syncfusioncontrolinmaui.CustomControls;

public partial class CustomTextInputLayout : ContentView
{
	public CustomTextInputLayout()
	{
		InitializeComponent();
	}
	public static readonly BindableProperty TextProperty =
			BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomTextInputLayout), string.Empty, BindingMode.TwoWay);

	public string Text
	{
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}

	public static readonly BindableProperty LabelTextProperty =
		BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomTextInputLayout), string.Empty);

	public string LabelText
	{
		get => (string)GetValue(LabelTextProperty);
		set => SetValue(LabelTextProperty, value);
	}

	public static readonly BindableProperty PlaceholderProperty =
		BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(CustomTextInputLayout), string.Empty);

	public string Placeholder
	{
		get => (string)GetValue(PlaceholderProperty);
		set => SetValue(PlaceholderProperty, value);
	}

	public static readonly BindableProperty HasErrorProperty =
		BindableProperty.Create(nameof(HasError), typeof(bool), typeof(CustomTextInputLayout), false);

	public bool HasError
	{
		get => (bool)GetValue(HasErrorProperty);
		set => SetValue(HasErrorProperty, value);
	}

	private void OnEntryFocused(object sender, FocusEventArgs e)
	{
		//CustomTextInputLayout.BorderColor = Colors.Blue;
	}

	private void OnEntryUnfocused(object sender, FocusEventArgs e)
	{
		//textInputLayout.BorderColor = HasError ? Colors.Red : Colors.Gray;
	}
}