namespace syncfusioncontrolinmaui;

public partial class NavigationDrawer : ContentPage
{
	public NavigationDrawer()
	{
		InitializeComponent();
	}
	private void hamburgerButton_Clicked(object sender, EventArgs e)
	{
		navigationDrawer.ToggleDrawer();
	}

	private void collectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		if (e.CurrentSelection.FirstOrDefault() is string selectedItem)
		{
			headerLabel.Text = selectedItem;
			contentLabel.Text = $"{selectedItem} Content";
			navigationDrawer.ToggleDrawer();
		}
	}
}