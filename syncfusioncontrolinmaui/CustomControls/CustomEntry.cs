using Syncfusion.Maui.Core;
using static System.Net.Mime.MediaTypeNames;

namespace syncfusioncontrolinmaui.CustomControls;

public class CustomEntry : ContentView
{
	private Label _errorIcon;

	public static readonly BindableProperty LabelTextProperty =
		BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomEntry), default(string));

	public static readonly BindableProperty TextProperty =
		BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomEntry), default(string), BindingMode.TwoWay);

	public static readonly BindableProperty ShowErrorIconProperty =
		BindableProperty.Create(nameof(ShowErrorIcon), typeof(bool), typeof(CustomEntry), false, propertyChanged: OnShowErrorIconChanged);

	public string LabelText
	{
		get => (string)GetValue(LabelTextProperty);
		set => SetValue(LabelTextProperty, value);
	}

	public string Text
	{
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}

	public bool ShowErrorIcon
	{
		get => (bool)GetValue(ShowErrorIconProperty);
		set => SetValue(ShowErrorIconProperty, value);
	}

	public CustomEntry()
	{
		
		var entry = new Entry
		{
			BackgroundColor = Colors.Transparent,
			Text="Ravi",
			TextColor = Colors.Black//,
			//HorizontalOptions = LayoutOptions.FillAndExpand
		};
		entry.SetBinding(Entry.TextProperty, new Binding(nameof(Text), source: this, mode: BindingMode.TwoWay));

		_errorIcon = new Label
		{
			Text = "\ue78f",
			FontFamily = "MaterialAssets",
			FontSize = 20,
			TextColor = Colors.Red,
			VerticalOptions = LayoutOptions.Center,
			IsVisible = ShowErrorIcon,
			Margin = new Thickness(5, 0, 0, 0)
		};

		

		var inputLayout = new SfTextInputLayout
		{
			Hint = "",
			ContainerType = ContainerType.Outlined,
			HeightRequest = 60,
			WidthRequest = 300
			
		};

		var stack = new VerticalStackLayout
		{
			Spacing = 2,
			Children = {  inputLayout }
		};

		Content = stack;
	}

	private static void OnShowErrorIconChanged(BindableObject bindable, object oldValue, object newValue)
	{
		if (bindable is CustomEntry control && control._errorIcon != null)
		{
			control._errorIcon.IsVisible = (bool)newValue;
		}
	}
}