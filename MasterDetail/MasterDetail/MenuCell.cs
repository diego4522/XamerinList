using Xamarin.Forms;

public class MenuCell : ViewCell
{
	public MenuCell () : base ()
	{
		 var image = new Image
		{
			HorizontalOptions = LayoutOptions.Start
		};
		image.SetBinding(Image.SourceProperty, new Binding("IconSource"));
		image.WidthRequest = image.HeightRequest = 40;
		 
		var nameLayout = CreateNameLayout();

		var viewLayout = new StackLayout()
		{
			Orientation = StackOrientation.Horizontal,
			Children = { nameLayout, image }
		};

		View = viewLayout;

	
		//this.TextColor = Color.FromHex ("AAAAAA");

	}
	static StackLayout CreateNameLayout()
	{

		var nameLabel = new Label
		{
			HorizontalOptions= LayoutOptions.FillAndExpand
		};
		nameLabel.SetBinding(Label.TextProperty, "Title");

		var twitterLabel = new Label
		{
			HorizontalOptions = LayoutOptions.FillAndExpand,
		};
		twitterLabel.SetBinding(Label.TextProperty, "Correo");

		var nameLayout = new StackLayout()
		{
			HorizontalOptions = LayoutOptions.StartAndExpand,
			Orientation = StackOrientation.Vertical,
			Children = { nameLabel, twitterLabel }
		};
		return nameLayout;
	}
}