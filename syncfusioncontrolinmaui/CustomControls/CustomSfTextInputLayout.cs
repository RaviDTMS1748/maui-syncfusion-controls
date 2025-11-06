using Microsoft.Maui.Controls;
using Syncfusion.Maui.Core;

namespace syncfusioncontrolinmaui.CustomControls;

public class CustomSfTextInputLayout : ContentView
{



	private readonly SfTextInputLayout _textInputLayout;
	private readonly Entry _entry;
	private readonly Label _label;

	public static readonly BindableProperty TextProperty =
		BindableProperty.Create(nameof(Text), typeof(string), typeof(CustomSfTextInputLayout), default(string), BindingMode.TwoWay);

	public static readonly BindableProperty LabelTextProperty =
		BindableProperty.Create(nameof(LabelText), typeof(string), typeof(CustomSfTextInputLayout), default(string), BindingMode.OneWay);

	public static readonly BindableProperty LocalizedCodeProperty =
		BindableProperty.Create(nameof(LocalizedCode), typeof(string), typeof(CustomSfTextInputLayout), default(string), BindingMode.OneWay);

	public string Text
	{
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}

	public string LabelText
	{
		get => (string)GetValue(LabelTextProperty);
		set => SetValue(LabelTextProperty, value);
	}

	public string LocalizedCode
	{
		get => (string)GetValue(LocalizedCodeProperty);
		set => SetValue(LocalizedCodeProperty, value);
	}

	public CustomSfTextInputLayout()
	{
		_label = new Label
		{
			FontSize = 16,
			TextColor = Colors.Black
		};
		_label.SetBinding(Label.TextProperty, new Binding(nameof(LabelText), source: this));

		_entry = new Entry
		{
			Keyboard = Keyboard.Numeric,
			FontSize = 16,
			BackgroundColor = Colors.Transparent,
			

		};
		_entry.SetBinding(Entry.TextProperty, new Binding(nameof(Text), source: this, mode: BindingMode.TwoWay));


		
		
		_textInputLayout = new SfTextInputLayout
		{
			ContainerType = ContainerType.Outlined,
			OutlineCornerRadius = 0,
			FocusedStrokeThickness = 2,
			UnfocusedStrokeThickness = 1,
			//HintType = HintType.None,
			//BorderColor = Colors.Black,
			//BorderThickness = 2,
			Padding = -5,
			Margin = 0
		};
		_textInputLayout.Content = _entry;

		Content = new VerticalStackLayout
		{
			Spacing = 4,
			Children = { _label, _textInputLayout }
		};
	}
	
}